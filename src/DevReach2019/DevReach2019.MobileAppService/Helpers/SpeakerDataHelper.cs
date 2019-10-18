using System.Collections.Generic;
using DevReach2019.MobileAppService.Models;

namespace DevReach2019.MobileAppService.Helpers
{
    public class SpeakerDataHelper
    {
        static SpeakerDataHelper()
        {
            Speakers = GetSpeakers();
        }

        public static List<Speaker> Speakers { get; }

        private static List<Speaker> GetSpeakers()
        {
            var speakers = new List<Speaker>
            {
                new Speaker
                {
                    Id = "a995eb1b-7405-413c-967f-268f327fdfef",
                    Name = "Heather Downing",
                    Company = "Okta",
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/downing.jpeg",
                    SocialUrls = new List<string>(){"https://twitter.com/quorralyne","https://www.linkedin.com/in/heathermdowning/"},
                    Bio = "Heather is a passionate coder and entrepreneur. She has experience working with Fortune 500 companies building enterprise-level voice, mobile and C#/.Net applications. She focuses on external thought leadership, encouraging fellow programmers to present on topics outside of the office and in the community. She is an international technical speaker and co-host of the YouTube channel \"The Hello World Show\" -- a weekly video series that interviews software masters and teaches the audience something valuable in less than 10 minutes.  Heather encourages those with nontraditional backgrounds to enter the world of software development, as she changed careers at 27 and does not have a degree - yet has built a reputation as an early adapter of new tech. She is an advocate of women in tech, and part of Kansas City Women in Technology. When not coding, Heather spends her time as a competitive equestrian and learning the art of mounted archery."
                },
                new Speaker
                {
                    Id = "4cb00fa7-e657-4209-b2fc-29f142ced977",
                    Name = "Jody Davis",
                    Company = "Government",
                    Position = "Aerospace Engineer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/davis.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/TangoDeltaNom"},
                    Bio = "Jody Davis is an Aerospace Engineer at NASA Goddard Space Flight Center. She earned a B.S. in Aerospace Engineering from Embry-Riddle Aeronautical University and an M.S. in Mechanical and Aerospace Engineering from University of Virginia. Jody has worked missions such as Mars Phoenix and Mars Science Laboratory, specializing in entry, descent and landing flight dynamics and trajectory simulation at NASA Langley Research Center. She served as the NASA Langley Technical Lead for the Low-Density Supersonic Decelerator (LDSD) flight test project. She also served as the James Webb Space Telescope (JWST) Optical Telescope Element & Integrated Science Instrument Module (OTIS) Responsible Engineer for the Harnesss Radiator at NASA Goddard, working systems engineering and flight hardware integration and test. She now supports the Wide Field Infrared Survey Telescope (WFIRST) as the Deputy Payload Systems Engineer. Jody’s hobbies include flying recreationally, hiking, traveling, running marathons, and participating in national and international STEM outreach activities. She also traveled to Tanzania and summitted Kilimanjaro in January 2018."
                },
                new Speaker
                {
                    Id = "161dc9b0-078b-47c5-9b89-ee1510cd1b1c",
                    Name = "James Montemagno",
                    Company = "Microsoft",
                    Position = "Program Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/montemagno.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/jamesmontemagno"},
                    Bio = "James Montemagno is a Principal Program Manager for Mobile Developer Tools at Microsoft. He has been a .NET developer since 2005, working in a wide range of industries including game development, printer software, and web services. Prior to becoming a Principal Program Manager, James was a professional mobile developer and has now been crafting apps since 2011 with Xamarin. In his spare time, he is most likely cycling around Seattle or guzzling gallons of coffee at a local coffee shop. He blogs code regularly on his personal blog @ http://www.montemagno.com and co-hosts the weekly development podcast Merge Conflict @ http://mergeconflict.fm."
                },
                new Speaker
                {
                    Id = "71bc0c81-d5c0-4651-9094-c8d675fb8e87",
                    Name = "Antoniya Boynovska",
                    Company = "Progress",
                    Position = "Product Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/boynovska.jpg",
                    SocialUrls = new List<string>(),
                    Bio = "Antoniya has experience in leading projects, teams, and processes in IT.  At Progress she is embracing product management responsibilities for a novel solution that bridges the gap in team collaboration in tech teams. In her spare time, she enjoys traveling, reading both professional literature and fiction as part of her book club, enjoys a good wine and watching the sunset."
                },
                new Speaker
                {
                    Id = "472f59a9-585a-488c-8ffa-637e1490f43b", 
                    Name = "Bozhidar Ivanchev", 
                    Company = "Progress", 
                    Position = "Software Architect",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Ivanchev.jpg", 
                    Bio = "Bozhidar is a Software Architect in the Progress Telerik team, with a 8 year history in the company's ASP.NET Ajax, Kendo, MVC and Blazor teams. He enjoys working with people, tinkering with old and buggy legacy code, as well as building something from nothing on a new technology."
                },
                new Speaker
                {
                    Id = "055f8bd3-ea18-4c72-9ded-b31b0cf4a5a1", 
                    Name = "Carl Bergenhem", 
                    Company = "Progress", 
                    Position = "Product Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Bergenhem.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/carlbergenhem"},
                    Bio = "Carl Bergenhem is the Product Manager for Kendo UI. Throughout his time at Telerik/Progress he has covered the entire portfolio of products offered, but mainly spent his time in the web development arena covering ASP.NET Ajax, ASP.NET MVC, and JavaScript-based products. He’s passionate about web technologies and tries to stay on top of all JavaScript libraries and frameworks relating to Kendo UI, developing with jQuery, Angular, React, and Vue.js on a regular basis. In his free time Carl enjoys slaying virtual monsters, snowboarding and playing his guitar."
                },
                new Speaker
                {
                    Id = "952f0bde-472e-49dc-8b23-eaaf8a1ec62b", 
                    Name = "Chris DeMars", 
                    Company = "Tuft & Needle", 
                    Position = "Front End Developer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/DeMars.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/saltnburnem"},
                    Bio = "Chris DeMars is a front end developer from Detroit, Michigan now living in Denver, Colorado. For his community contributions, he holds awards as a Microsoft MVP in developer technologies, Google Developer Expert in web technologies, and is an Oracle Groundbreaker Ambassador. Chris loves coming up with solutions for all types of applications, which include modular CSS architectures, performance, and advocating for web accessibility. When he is not working on making the web great and inclusive you can find him writing blog posts, recording episodes of his podcast, Tales From The Script, or watching horror movies."
                },
                new Speaker
                {
                    Id = "fdbb3ef8-9761-4a14-aa55-9a9555cbfa58",
                    Name = "Dan Siegel", 
                    Company = "AvantiPoint", 
                    Position = "Founder/Consultant",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Siegel.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/DanJSiegel"},
                    Bio = "Dan is a Microsoft/Xamarin MVP, an avid OSS Contributor and Author best known as for his work as a maintainer of the immensely popular Prism Library. He is a Consultant specializing in Cloud, Mobile and DevOps with perhaps one of the most unique backgrounds of any programmer you'll ever meet. He loves to share his passion for developing mobile apps with developers around the world, and is the organizer of the Xamarin Developer Summit.\r\n\r\nIn those arguably rare moments he's not busy slinging code you may find him out Scuba Diving, Off-Roading or through hiking in the remote wilderness."
                },
                new Speaker
                {
                    Id = "c1a7953e-688f-42aa-b4b1-9839d5d08a35",
                    Name = "Daniel Levy", 
                    Company = "Progress", 
                    Position = "Product Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Levy.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/dlevy"},
                    Bio = "Daniel is Sr. Director, Customer Success at Progress and is based in Portland, OR. Daniel has a passion for technology, a vision for product, and a story to tell. When he is not at the keyboard, you’ll likely find him out on a hike in the Cascades or behind a camera at sunrise."
                },
                new Speaker
                {
                    Id = "1caef8d2-bdc3-4f96-b069-a566af3c2c7f", 
                    Name = "David Pine", 
                    Company = "Microsoft", 
                    Position = "Content Developer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Pine.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/davidpine7","https://github.com/ievangelist"},
                    Bio = "David Pine is a 2x Microsoft MVP, Google Developer Expert, Twilio Champion and a Content Developer working at Microsoft. David loves knowledge sharing with the technical community and speaks internationally at meetups, user groups, and technical conferences. David is passionate about sharing his thoughts through writing as well and actively maintains a blog at davidpine.net. David's posts have been featured on ASP.NET, MSDN Web-Dev, MSDN .NET, Dot Net Curry, Twilio and InfoQ. David loves contributing to open-source projects and StackOverflow.com as another means of giving back to the community. David sat on the technical board and served as one of the primary organizers of Cream City Code, going four years now. When David isn’t interacting with a keyboard, you can find him spending time with his wife and their three sons, Lyric, Londyn and Lennyx."
                },
                new Speaker
                {
                    Id = "d4379470-69bf-4adb-bb31-d87dfa917777", 
                    Name = "Dean Schuster", 
                    Company = "TrueMatter", 
                    Position = "UX Guru",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Schuster.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/experiencedean","https://www.linkedin.com/in/dean-schuster-4b906b4"},
                    Bio = "Founder and partner of truematter, a user experience strategy firm, Dean has been advocating for user-centered digital products his entire career. He oversees truematter’s UX practice, leading strategic engagements for innovative regional organizations as well as the Fortune 100.\r\n\r\nDean’s work has always included researching, prototyping, and testing digital products with real users. He regularly speaks, writes, and teaches on experience design, user experience strategy, usability, user research, content strategy, and building UX-focused teams.\r\n\r\nIt’s not all UX all the time (even though it’s close). Dean is also an avid ultra marathoner, reader, and traveler."
                },
                new Speaker
                {
                    Id = "903f6f1a-ff07-44d5-8f40-585dd390902d", 
                    Name = "Doncho Angelov", 
                    Company = "SEGA", 
                    Position = "Director of Development",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Angelov.jpg",
                    SocialUrls = new List<string>(),
                    Bio = "Doncho Angelov is a Director of Development Services in SEGA. He earned an M.Sc. in Computer Science from Technical University - Sofia, and an Executive MBA from the American University in Bulgaria. Doncho has worked as C++ back-end and C# front-end developer for various companies, including the Bulgarian Object Builder Software (today DXC, former CSC) and Microsoft Development Center Copenhagen.\r\n\r\nHe started his leadership career in 1999, going through various roles both in the technical leadership and people management at OBS, Microsoft Denmark and Microsoft Bulgaria. After these, and for the past 9 years, his primary job has been building engineering teams, which started in 2011 with the foundation of the Bulgarian site of Milestone Systems. With the help of the great people around him, the site grew to 130 employees in 2018, with current numbers close to 150. Today he's building the Development Services organization for SEGA Black Sea, a subsidiary of SEGA of Europe.\r\n\r\nOne of the toughest tasks in these roles is identifying the right people, who can successfully lead others through out technical assignments and small to large projects. This taught, and still teaches him, the importance of selecting and nurturing the unique skill of technical leadership. This also taught him how hard this process is, and how error-prone we are when trying to get and train the right leads.\r\n\r\nDoncho's hobbies include traveling, computer gaming, and Bulgarian folk dancing. He's a proud father of three, which often teaches him how hard is to implement leadership learnings at home."
                },
                new Speaker
                {
                    Id = "a36183d8-0192-4314-8bc6-3d0a815a746a", 
                    Name = "Doug Mair", 
                    Company = "AEP", 
                    Position = "Tech Anchor",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/mair.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/Doug_Mair"},
                    Bio = "Doug is a Tech Anchor at AEP Charge in Columbus, Ohio. He started developing software as a high school freshman on a TRS-80 16K. Since then, he has developed software for Graphics Kiosks, Rules Engines, Specialized Hardware and ASP.NET websites. Over the last few years, he has helped grow the Windows Developer Community in Central Ohio and he spends his free time developing Windows applications and playing board games."
                },
                new Speaker
                {
                    Id = "bced2e9a-f1c4-4ecd-9fd4-bc76935287b2", 
                    Name = "Ed Charbeneau", 
                    Company = "Progress", 
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Charbeneau.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/EdCharbeneau","https://github.com/EdCharbeneau"},
                    Bio = "Ed is a Microsoft MVP and an international speaker, writer, online influencer, a Developer Advocate for Progress, and expert on all things web development. Ed enjoys geeking out to cool new tech, brainstorming about future technology, and admiring great design.\r\n\r\nEd has shared his insights, experiences, and advice around collaboration, knowledge management, social computing, and training at many industry events around the United States. Highly ethical and engaging with an uncanny business acumen, he is a creative community builder and outside the box thinker. Long term business relationships throughout the world within internal communications, employee engagement and marketing as well as IT. Focusing on Financial, Healthcare, Manufacturing, Agency and Professional Services. He has defined, architected, implemented line of business solutions with a touch of style and UX best practices."
                },
                new Speaker
                {
                    Id = "4341d469-0fd7-4061-94b7-8e466e7259b9", 
                    Name = "Eric Bishard", 
                    Company = "Progress", 
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Bishard.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/httpJunkie","https://github.com/httpJunkie"},
                    Bio = "With a focus on fundamentals first, Eric loves teaching others to build solid React UI's. A front end developer since the early 2000's, he's always focused on web applications and more recently worked on full stack in .NET applications and specialized in SPA frameworks like React."
                },
                new Speaker
                {
                    Id = "d7143f9c-ea6b-4d60-ad01-bb3b2f0c425c", 
                    Name = "Euan Finlay", 
                    Company = "Financial Times", 
                    Position = "Operations Lead",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Finlay.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/efinlay24"},
                    Bio = "Euan is part of the Operations & Reliability team at the Financial Times, managing incidents across the globe. Before that, he lead a distributed team responsible for Go microservices, Docker containers in Kubernetes, and the backend APIs powering the website.\r\n\r\nOn the Ops-ier side of DevOps, he has occasionally admitted to being a sysadmin in public."
                },
                new Speaker
                {
                    Id = "0491fc8a-9975-415b-8eb6-d9d073e66641",
                    Name = "Guy Royse",
                    Company = "ScriptDrop",
                    Position = "Software Craftsman",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Royse.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/guyroyse", "http://linkedin.com/in/groyse", "https://github.com/guyroyse"},
                    Bio = "Guy likes to combine his decades of experience in writing software with a passion for sharing what he has learned. Guy goes out into developer communities and helps others build great software. Teaching and community have long been a focus for Guy. He is President of the Columbus JavaScript Users Group, an organizer for the Columbus Machine Learners, and has even has helped teach programming at a prison in central Ohio. In past lives, Guy has worked as a consultant in a broad range of industries including healthcare, retail, and utilities. He also has spent several years working for a major insurance company in central Ohio. This has given him a broad view of technology application toward business problems. In his personal life, Guy is a hard-boiled geek interested in role-playing games, science fiction, and technology. He also has a slightly less geeky interest in history and linguistics. In his spare time, he volunteers for his local Cub Scout Pack, goes camping, and studies history and linguistics. Guy lives in Ohio with his wife, his three teenage sons, and an entire wall of games."
                },
                new Speaker
                {
                    Id = "aede7a28-6aca-49e6-a417-2a828acee88c",
                    Name = "Ilia Idakiev",
                    Company = "Sofia University",
                    Position = "Lecturer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Idakiev.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/ilia_idakiev"},
                    Bio = "Iliya Idakiev is a Google Developer Expert (GDE), software developer-entrepreneur, as well as a JavaScript enthusiast who has many years of experience in web application development. He is a co-organizer of Angular Sofia and SofiaJS / BeerJS, and he is a lecturer at Sofia University of the 'Advanced JavaScript' course at the Faculty of Mathematics and Informatics. In his spare time he likes collecting and playing vinyl on different musical events."
                },
                new Speaker
                {
                    Id = "182a26cb-0e98-4c09-b699-74b8a957e044",
                    Name = "Ivan Zhekov",
                    Company = "Progress",
                    Position = "Front End Developer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Zhekov.jpg",
                    SocialUrls = new List<string>(),
                    Bio = "Ivan has been a web front end guy for the better part of his life. He enjoy languages, language constructs and cunning use -- think hip-hop, George Carlin and, as it happens, code. Ivan been lucky enough to be employed to do the one thing he do best -- describe the world around him through CSS and Javascript. Lager lover, chill out connoisseur, asics aficionado & nawashi wannabe. Formerly, the most prolific RedBull user in Bulgaria."
                },
                new Speaker
                {
                    Id = "e6a12a4c-5e19-4208-84a4-50e1d48c7490",
                    Name = "Jessica Engstrom",
                    Company = "AZM Dev",
                    Position = "UX Expert",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/engstromjessica.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/EngstromJess"},
                    Bio = "Jessica is an international speaker,  teacher,  podcaster,  mentor,  geek and the CEO of her own company. She is very passionate about the developer community where she organizes conferences, events, and runs multiple user groups. This, amongst other things, has led her to be awarded Windows Platform Development MVP six years in a row.\r\n\r\nShe started out in the development world and soon realized that it was the user experience and interaction that excited her. One thing she's sure of is that you can never learn enough, and this is why she is continuously learning new things, researching, and trains with the best people in the world.\r\n\r\nHer company does trainings, workshops, UX research and development in areas focused on HoloLens, VR/AR/MR, cognitive services, UX, chat/speech bots, Windows development and speaker skills."
                },
                new Speaker
                {
                    Id = "2a205aa0-f286-46d7-84d8-9873974450d1",
                    Name = "Jimmy Engström",
                    Company = "AZM Dev",
                    Position = "AR/VR Expert",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/engstromjimmy.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/EngstromJimmy"},
                    Bio = "At the age of 7 Jimmy got his first computer, a ZX Spectrum, and since then he hasn´t stopped coding. He has a passion for everything new and together with his wife he runs a company called Azm Dev focused on just that, everything new.\r\n\r\nWhen he doesn´t code (yes, there are moments like those even if they are few), he spends his time learning new things and teaching them to others. He is also a presentation skills nut and takes every opportunity to learn more and coach new/seasoned speakers.\r\n\r\nJimmy has spoken at conferences all around the world which has led him to become a Microsoft MVP for the sixth year in a row. He is a co-host for Coding After Work Podcast."
                },
                new Speaker
                {
                    Id = "ba7953fe-a806-4541-b29a-aa901676d98f",
                    Name = "John Bristowe",
                    Company = "Progress",
                    Position = "Developer Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Bristowe.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/JohnBristowe"},
                    Bio = ""
                },
                new Speaker
                {
                    Id = "916c4b37-b0d7-4523-95ec-9177e854dc61",
                    Name = "Lance McCarthy",
                    Company = "Progress",
                    Position = "Support Engineer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/mccarthy.jpg",
                    SocialUrls = new List<string>{ "https://twitter.com/lancewmccarthy", "https://github.com/LanceMcCarthy"},
                    Bio = "Lance, a Windows Dev Microsoft MVP, loves volunteering and mentoring developers in the community. Previously with Nokia and Microsoft as DX, is a Principal Technical Support Engineer at Progress Software specializing in .NET and Web technologies and prefers XAML and C#. In his spare time, he’s an author, hardware hacker, 3D printing fan, Hololens/WinMR dev and open source contributor."
                },
                new Speaker
                {
                    Id = "e72da88e-f9c5-48e1-b774-c4e7e0b51a76",
                    Name = "Lino Tadros",
                    Company = "Solliance",
                    Position = "Solutions Architect",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Tadros.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/linotadros"},
                    Bio = "Alain \"Lino\" Tadros is the President & CEO of Events XD Corporation and a Cloud Solution Architect for AI & Machine Learning. Lino has 13 years of experience with Sitefinity and built over 350 Sitefinity applications for corporations worldwide.  Lino is the author of 7 technical books on Sitefinity and is also the author of the Sitefinity Development certification exam. He has been awarded Microsoft MVP status 15 years in a row and is an expert in .NET, Azure, AI & Machine Learning, IoT, MVC, iOS, Android, Xamarin, Sitefinity and Google Cloud. He is an industry renowned speaker and has given numerous presentations in 52 countries over 28 years. He also currently sits on the Board of Directors of 4 Silicon Valley Software corporations.  Lino is currently studying AI & Machine Learning at MIT."
                },
                new Speaker
                {
                    Id = "52da761a-8d3b-46d4-a186-50ddfa89f484",
                    Name = "Martin Zikmund",
                    Company = "Independent",
                    Position = "OSS Developer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Zikmund.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/mzikmunddev"},
                    Bio = "Martin is a freelance software developer and Microsoft Developer Technologies MVP. He specializes in architecting and building cross-platform mobile and cloud solutions on the Microsoft technology stack. Martin loves contributing to open-source, as it is a tremendous source of learning. You can also meet him on Stack Overflow, where he frequently helps other developers. To document his developer journey, Martin regularly writes posts on his blog at https://blog.mzikmund.com/. In spare time he likes to play squash, game on Xbox, read, and search for geocaches."
                },
                new Speaker
                {
                    Id = "864224c2-65ce-4e71-87f0-8c51a2420ccf",
                    Name = "Mihail Vladov",
                    Company = "Progress",
                    Position = "Engineering Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Vladov.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/MihailVladov"},
                    Bio = "Mihail Vladov has been a software developer for around 13 years and is currently the Software Engineering Manager for JustMock at Progress. He started working for Telerik/Progress back in 2011, and has contributed to develop the WPF controls suite and Document Processing libraries.\r\n\r\nHe is passionate about building quality software and has huge experience in designing software architectures. Mihail often conducts strategic thinking sessions and is a firm believer in rapid innovations. In his spare time, he loves spending time with his family and enjoying his aquarium."
                },
                new Speaker
                {
                    Id = "f9ca6d07-6f5d-4881-abf9-b65e4ead1337",
                    Name = "Milan Nankov",
                    Company = "Independent",
                    Position = "Software Craftsman",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Nankov.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/milannankov"},
                    Bio = "Milan Nankov has been developing software for more than 12 years, helping companies (big and small) navigate through the treacherous process of building robust business software. As a student of Domain-Driven Design, he is fascinated by the process of distilling domain knowledge into code and how this process affects both the software and the business. Milan regularly shares his experience building software at conferences and on his personal blog."
                },
                new Speaker
                {
                    Id = "0164b8f9-c526-4c15-9276-c73314966be3",
                    Name = "Olia Gavrysh",
                    Company = "Microsoft",
                    Position = "Program Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Gavrysh.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/oliagavrysh"},
                    Bio = "Olia Gavrysh is a program manager on the .NET team at Microsoft. She has a background in software development & machine learning, and worked on the beginnings of ML.NET. Now she focuses on desktop developer tools, WinForms and porting applications to .NET Core experience."
                },
                new Speaker
                {
                    Id = "9bd0ffee-a53a-4bba-9ca6-d315555d0639",
                    Name = "Panayot Cankov",
                    Company = "Progress",
                    Position = "AR/VR Expert",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Cankov.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/PanayotCankov","https://github.com/PanayotCankov"},
                    Bio = "Panayot has 15 years of experience focused on UI. For 9 years in Progress, he has been working on the XAML stack and the NativeScript framework.\r\n\r\nToday he is pushing forward AR/VR technologies as he is a big believer in those, along with AI/ML for being the foundation of the next generation line of business application experiences."
                },
                new Speaker
                {
                    Id = "ff01e002-64c9-4e4f-9cc4-699003a6f508",
                    Name = "Rachel Appel",
                    Company = "JetBrains",
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Appel.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/RachelAppel"},
                    Bio = "Rachel currently works for JetBrains as a Developer Advocate. She has been in the business of creating software for over 25 years, as an author, mentor, and speaker at top industry conferences such as Microsoft BUILD, Oredev, NetConf, SDD and others. During her career, she has worked on projects of all sizes from the smallest of apps, to the largest enterprise systems at some of the world’s leading companies.\r\n\r\nRachel’s expertise is in web development on the Microsoft stack, specifically Azure Functions, ASP.NET MVC, Web Forms, SignalR, C#, HTML, CSS, JavaScript, and TypeScript. Her hobbies include science, reading, languages, and travel."
                },
                new Speaker
                {
                    Id = "4d07ee99-eb2b-4eeb-9c06-2241310ce3a0",
                    Name = "Richard Taylor",
                    Company = "SentryOne",
                    Position = "VP Engineering",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Taylor.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/rightincode"},
                    Bio = "Richard L. Taylor Jr. is a 25 year software development and technology professional living in Huntersville, NC. His experience includes the design and development of small to enterprise class applications. He currently serves as Vice President of Platform and Cloud Engineering at SentryOne. Richard is a believer of using the right tools for the job and has leveraged ASP.NET (Web API, MVC), SQL Server/MongoDB, Angular, Bootstrap, JavaScript/NodeJS, KendoUI, and Xamarin (just to name a few) to deliver solutions. He has a great deal of experience but likes to explore new technologies, tools, and techniques to help create better software. Richard has a passion for the software development community. He serves as one of the organizers of the Modern Devs Charlotte meetup group and is the founding organizer of the Charlotte Xamarin Developers meetup group. Both groups try to create environments where developers of all skill levels can come together and learn about the latest technologies, tools, and techniques to create software. These groups also provide a venue to network with fellow developers in the community. In addition to serving the local software development community via meetup groups, Richard also speaks at regional, national, and international technology users groups and conferences. His speaking schedule can be found here: http://www.rightincode.com/page/speaking-schedule Richard recently received the Progress (Telerik) Developer Expert designation. DE’s are highly skilled, visible, and elite industry leaders who write, speak, help, and code using Progress (Telerik) products. There are 44 DE’s in 13 different countries who are ambassadors for Progress Products to the tech community. When not developing software, Richard is focused on spending time with his lovely wife Shondrecca (she gives the best hugs!!) and their five children (Richard III, Ayanna, David, Jonathan, and Stephen)."
                },
                new Speaker
                {
                    Id = "e506d98a-bfd1-473f-84c7-67fef6facfd3",
                    Name = "Rob Lauer",
                    Company = "Progress",
                    Position = "DevRel Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Lauer.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/RobLauer"},
                    Bio = "Rob Lauer is Senior Manager of Developer Relations at Progress (formerly Telerik). A long time .NET WebForms/MVC developer, Rob is now focused on JavaScript-driven native mobile development with NativeScript."
                },
                new Speaker
                {
                    Id = "c5d27676-e04a-418e-9eef-79ced0da01a2",
                    Name = "Robert Boedigheimer",
                    Company = "Schwans",
                    Position = "Web Expert",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Boedigheimer.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/boedie"},
                    Bio = "Robert Boedigheimer works for Schwans Shared Services, LLC providing business solutions with web technologies. Robert has been developing web sites for the past 25 years. He is a Microsoft  MVP, a Progress Developer Expert (Fiddler), an ASPInsider, a Pluralsight author, and a 3rd degree black belt in Tae Kwon Do. Robert regularly speaks at national and international events."
                },
                new Speaker
                {
                    Id = "1a6057f3-5941-41eb-b3fc-f9bc29be10f1",
                    Name = "Robert Green",
                    Company = "Microsoft",
                    Position = "Program Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Green.jpg",
                    SocialUrls = new List<string>(){"https://twitter.com/rogreen_ms"},
                    Bio = "Robert Green is a Program Manager Evangelism in the Developer Experience and Evangelism (DX) group at Microsoft. He focuses on Visual Studio and mobile development. Robert is the host of the Visual Studio Toolbox show on Channel 9."
                },
                new Speaker
                {
                    Id = "bad65784-fe93-457f-b23b-3e0d3593f380",
                    Name = "Ross Borissov",
                    Company = "Progress",
                    Position = "DevOps Lead",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Borissov.jpg",
                    SocialUrls = new List<string>(),
                    Bio = "14+ years in the IT industry. Started his career as a software developer with .NET 1.0. Fell in love with the DevOps practices while managing the internal .NET related infrastructure at SAP. Enjoying the DevOps transformation at Progress as a servant leader responsible for the ALM lifecycles of a few product lines. Passionate about cutting edge physics."
                },
                new Speaker
                {
                    Id = "0f3125d3-9618-4e7e-98ae-f60c3a9fdf0b",
                    Name = "Rossitza Fakalieva",
                    Company = "Progress",
                    Position = "Director of Engineering",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Fakalieva.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/fakalieva"},
                    Bio = "Rossitza is a Director of Software Engineering at Progress and leads one of the biggest team in the company, developing .NET components and tools such as Telerik UI for Xamarin, UWP, WinForms, WPF and Telerik JustMock. Rossitza has been working on our Progress Telerik tools since 2006. \r\n\r\nAlongside with her work at Progress, Rossi is dedicated to different tech initiatives. She is part of the leadership team of the Bulgarian edition of Women Who Code, a global organization that supports women in the tech industry to grow and develop."
                },
                new Speaker
                {
                    Id = "34b73482-ca92-421d-a9e7-2c4367d27904",
                    Name = "Sam Basu",
                    Company = "Progress",
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/proheadshot.jpg",
                    SocialUrls = new List<string>{ "https://twitter.com/samidip", "https://github.com/samidip"},
                    Bio = "Sam Basu is a technologist, author, speaker, Microsoft MVP, gadget-lover and Telerik Developer Advocate at Progress. With a long developer background, he now spends much of his time advocating modern web & mobile development platforms on Microsoft/Telerik technology stacks. His spare times call for travel, fast cars, cricket and culinary adventures."
                },
                new Speaker
                {
                    Id = "7354065a-d8ff-477e-94ea-c61a84fb1cc0",
                    Name = "Sara Faatz",
                    Company = "Progress",
                    Position = "DevRel Manager",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Faatz.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/sfaatz"},
                    Bio = "Sara Faatz is a senior manager on the Telerik and Kendo UI developer relations team at Progress. She has spent the majority of her career in the developer space building community, producing events, creating marketing programs, and more. When she's not working, she likes diving with sharks, running, and watching hockey."
                },
                new Speaker
                {
                    Id = "d0aeb34d-2010-4ea8-8fc4-9a319d7abebd",
                    Name = "Scott Addie",
                    Company = "Microsoft",
                    Position = "Content Developer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Addie.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/Scott_Addie"},
                    Bio = "Scott Addie is an international speaker, a .NET Foundation member, an open source contributor, and a developer advocate of the modern web. Scott has reached masses of developers through blog posts, articles, courses, and speaking engagements at user groups, code camps, and conferences across the globe. With a strong emphasis on the Microsoft web technology stack, Scott holds numerous industry-recognized Microsoft development certifications. Scott is a former Telerik Developer Network author, Progress Developer Expert, and Microsoft MVP. In his day job, Scott produces ASP.NET Core and Azure developer content for docs.microsoft.com and the Microsoft Learn platform."
                },
                new Speaker
                {
                    Id = "c4d1bddd-e096-4a7d-a7a1-9773a86d6c55",
                    Name = "Sebastian Witalec",
                    Company = "Progress",
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Witalec.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/sebawita","https://github.com/sebawita"},
                    Bio = "Sebastian Witalec is a Senior Developer Advocate for Progress who specializes in Angular and NativeScript. He loves working on both serious and fun projects and one day he will use his robot army to conquer the world. He is always happy to learn about the new stuff and to pass the knowledge as far as his voice (or the wire) can take him. Sebastian is based in London actively working with various Dev communities in Europe. When not acting techie he is a massive football fan/player (probably bigger at heart than skills)."
                },
                new Speaker
                {
                    Id = "47ecdb2c-a27e-42d3-a8aa-74f2bebd04dd",
                    Name = "Spencer Schneidenbach",
                    Company = "Ryvit",
                    Position = "Software Architect",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Schneidenbach.jpg",
                    SocialUrls = new List<string>{ "https://twitter.com/schneidenbach", "https://www.linkedin.com/in/sschneidenbach/"},
                    Bio = "Spencer Schneidenbach is a API and integration expert, Microsoft MVP, speaker, consultant, and blogger in the St. Louis, Missouri area."
                },
                new Speaker
                {
                    Id = "95f608f7-650d-412b-96a3-d675bdf114b6",
                    Name = "Stanimira Vlaeva",
                    Company = "Progress",
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/vlaeva.jpg",
                    SocialUrls = new List<string>{ "https://twitter.com/StanimiraVlaeva", "https://github.com/sis0k0"},
                    Bio = "Stanimira is a developer advocate on the NativeScript team at Progress, Google Developer Expert for Angular and Web Technologies, and co-organizer of the Angular Sofia meetup.\r\n\r\nFor the past three years she has been working on the integration between NativeScript and Angular, NativeScript schematics, the web and mobile code-sharing story, hot module replacement and the webpack performance optimization tricks (hacks)."
                },
                new Speaker
                {
                    Id = "7572d449-7c9c-4e35-8155-eb130d8034df",
                    Name = "Teodora Todorova",
                    Company = "bTalks Agile",
                    Position = "Co-Founder",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Todorova.jpg",
                    SocialUrls = new List<string>(),
                    Bio = "Teodora Todorova has been in the software industry for 15 years – she started as a developer and went through almost all roles involved in software project implementation.\r\n\r\nThroughout her career, Teodora has always been interested in examining the human behavior and in analyzing the project success factors related to processes/people. This is how her love for Agile was born, first as a mindset and attitude, and afterwards as established practices and flexible process. Agile is her real passion now and she tries to apply it in all aspects of her life.\r\n\r\nIn 2017, Teodora co-founded bTalks Agile, a consultancy that helps companies, teams and individuals to achieve better results in their Agile journeys by providing pragmatic coaching, training and consulting services. Her mission is to help people embrace the Agile mindset and optimize their processes by applying Agile practices."
                },
                new Speaker
                {
                    Id = "d944d7ed-64b5-4534-b1cf-a8734c3662c1",
                    Name = "TJ VanToll",
                    Company = "Progress",
                    Position = "Developer Advocate",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/VanToll.jpg",
                    SocialUrls = new List<string>{ "https://twitter.com/tjvantoll", "https://github.com/tjvantoll"},
                    Bio = "TJ VanToll is a front-end developer, author, and a Principal Developer Advocate for Progress. TJ has over a decade of web development experience, including a few years working on the jQuery team. Nowadays, he spends his time helping web developers build mobile apps through projects like NativeScript."
                },
                new Speaker
                {
                    Id = "7ad86657-7ffc-459d-8d87-529e996835f6",
                    Name = "Tomek Sulkowski",
                    Company = "StackBlitz",
                    Position = "Front-End Engineer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Sulkowski.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/sulco"},
                    Bio = "Tomek's biggest passion is making development experience not only performant and comfortable for seasoned programmers but also accessible and fun for the newcomers. That was what made him first fall in love with StackBlitz and then become part of its core team. \r\n\r\nIn his work, he is focusing on front-end technologies - especially the ecosystem around the Angular and React frameworks. He also loves to share useful development practices by running workshops, dev-events (co-organizing AngularTricity), in articles and the “tip-of-the-day” tweets."
                },
                new Speaker
                {
                    Id = "de03acdc-825e-4822-8c72-4a1dcdf79ab8",
                    Name = "Vasil Chimev",
                    Company = "Progress",
                    Position = "Software Engineer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Chimev.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/vchimev"},
                    Bio = "Vasil Chimev is a software developer on the NativeScript team at Progress Software. Currently, he works on the application framework and the cross-platform abstraction modules of NativeScript.\r\n\r\nIn his spare time, Vasil enjoys outdoor activities like mountain and seaside camping."
                },
                new Speaker
                {
                    Id = "da11ff42-1555-49e4-8bae-c2c845dcc5a1",
                    Name = "Veronica Milcheva",
                    Company = "Argo Ventures",
                    Position = "Sitefinity Expert",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Milcheva.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/SitefinityYoda"},
                    Bio = "My name is Veronica Milcheva and I am the CEO of Argo Ventures Digital Ltd. I've been part of the Sitefinity team for more than 3 years both in Core Development, Support and Documentation teams. \r\n\r\nArgo Ventures Digital is an award-winning B2B agency and official Sitefinity Partner. We are focused on all kinds of services related to the Sitefinity CMS, such as consulting, training, implementation, SEO, performance analysis etc. Argo Ventures Digital Ltd. has a proven record of projects with insurance, banking, governmental organizations from all over the globe including: United Kingdom, USA, UAE, Australia, Belgium, etc. and we are proud to have \"from the kitchen\" experience and best quality. We have been nominated as finalists for website of the Year 2017 and 2018 with 3 projects."
                },
                new Speaker
                {
                    Id = "2f89359b-4321-489d-92b3-f806aec8dc7b",
                    Name = "Vesko Kolev",
                    Company = "Progress",
                    Position = "VP Dev Tooling",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/kolev.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/veskokolev"},
                    Bio = "Vesko Kolev is a business and technology leader with 15 years of professional experience. He is part of the Progress leadership team in Bulgaria.  As VP of Product, Developer Tooling, at Progress Vesko is responsible for a team of more than 150 software engineers, technical support engineers, product managers, product marketers and UX designers based in the US and Bulgaria. His team develops the leading product lines, Progress Telerik and Progress Kendo UI. With his strategic business thinking and strong technical expertise, Vesko has played an instrumental role in the company’s success. He joined Progress in 2009 as a senior software developer and has held different managerial business and engineering roles over the years. He is passionate about helping people realize that their own potential is unlimited."
                },
                new Speaker
                {
                    Id = "5912e378-6cd7-483b-b9fa-e27b1ab3bac2",
                    Name = "Vladimir Milev",
                    Company = "Cobuilder",
                    Position = "Team Lead",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Milev.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/vmilev"},
                    Bio = "I have over 15 years of experience as a software engineer and architect in the C# and .NET world. During my career I have worked on projects ranging from low-level .NET UI components to high-level enterprise applications spanning desktop, web and mobile. I ran a consulting and professional services company for a while and also worked for bigger companies such as Progress/Telerik and Cobuilder. I always strive for continuous personal development and I love sharing my struggles and victories through blogging and speaking at technical conferences."
                },
                new Speaker
                {
                    Id = "a58803d1-02c0-49cf-94bf-62a848d95277",
                    Name = "Vladimir Mutafov",
                    Company = "Progress",
                    Position = "Software Engineer",
                    ImageUrl = "https://d585tldpucybw.cloudfront.net/sfimages/default-source/default-album/Mutafov.jpg",
                    SocialUrls = new List<string>{"https://twitter.com/VladimirMutafov"},
                    Bio = "Vladimir Mutafov is a software engineer on the NativeScript team at Progress Software. He's working on the NativeScript Android Runtime which provides all the high-performant JS to Java communication support."
                }
            };

            return speakers;
        }
    }
}
