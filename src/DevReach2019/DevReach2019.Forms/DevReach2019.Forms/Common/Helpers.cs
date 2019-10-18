using DevReach2019.Forms.Models;
using Microsoft.AppCenter.Crashes;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SkiaSharp.Views.Forms;

namespace DevReach2019.Forms.Common
{
    public static class Helpers
    {
        public static async Task<Xamarin.Forms.Color> CalculateBackgroundColorAsync(Speaker speaker)
        {
            try
            {
                var localFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var cachedFilePath = Path.Combine(localFolder, $"{speaker.Id}.png");

                // Cache the file now so that any future requests for the same speaker doesn't need to redownload it
                if (!File.Exists(cachedFilePath))
                {
                    using (Stream stream = await new HttpClient().GetStreamAsync(speaker.ImageUrl))
                    using (var fileStream = File.OpenWrite(cachedFilePath))
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                }

                // 
                using (var fileStream = File.OpenRead(cachedFilePath))
                using (MemoryStream memStream = new MemoryStream())
                {
                    // load stream into SKBitmap
                    await fileStream.CopyToAsync(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    var bitmap = SKBitmap.Decode(memStream);

                    // create a dictionary to keep track of the color that is used the most
                    var colors = new Dictionary<SKColor, int>();

                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        for (int y = 0; y < bitmap.Height; y++)
                        {
                            // get the pixel
                            SKColor color = bitmap.GetPixel(x, y);

                            if (colors.ContainsKey(color))
                            {
                                // Found the same color again, bump it
                                colors[color]++;
                            }
                            else
                            {
                                // new color found, give it its own entry
                                colors.Add(color, 1);
                            }
                        }
                    }

                    // Use LINQ to find the most prevenlent color
                    SKColor mostCommonColor = colors.Aggregate((left, right) => left.Value > right.Value ? left : right).Key;

                    // Convert it for use in Xamarin.Forms
                    return mostCommonColor.ToFormsColor();
                };
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>
                {
                    { "Location", "Helpers" },
                    { "Method", "CalculateBackgroundColorAsync" },
                    { "Speaker", speaker.Name }
                });

                return Xamarin.Forms.Color.FromHex("#AA000000");
            }
        }
    }
}
