using System;
using System.Collections.Generic;
using DevReach2019.MobileAppService.Models;

namespace DevReach2019.MobileAppService.Helpers
{
    public static class SessionDataHelper
    {
        static SessionDataHelper()
        {
            Sessions = GetSessions();
        }

        public static List<Session> Sessions { get; }

        private static List<Session> GetSessions()
        {
            var sessions = new List<Session>
            {
                // SUNDAY
                
                new Session
                {
                    Title = "ngGirls Workshop",
                    Id = "0284738d-3851-45bb-abd4-8d76f2292626",
                    SpeakerIds = new List<string> { "95f608f7-650d-412b-96a3-d675bdf114b6", "de03acdc-825e-4822-8c72-4a1dcdf79ab8" },
                    SessionType = "Workshop",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> { "Career skills" , "Web" },
                    StartTime = new DateTime(2019, 10, 20, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 20, 12, 0, 0),
                    Room = "Balkan Shipka + Balkan Kom | 6th Floor",
                    Description = "Are you a woman interested in learning how to build web applications with the latest technologies? We have good news for you: We are holding a half-day workshop for beginners!\r\n\r\nDuring the workshop you will build and deploy your very first Angular Web Application! Angular is an open-source platform for building web application, developed by Google and the community. It gives various tools to easily create a dynamic, interactive app that can run on desktop browser, mobile form factors and even robots!\r\n\r\nTo participate in the workshop you'll need some basic knowledge in web development: HTML, CSS and basic JavaScript or any other programming language. If you're a total beginner, here is a great resource to catch up. Come learn & build with us!"
                },
                new Session
                {
                    Title = "Vue Vixens Workshop",
                    Id = "8d51d935-f88d-41b0-bbca-f57fcd999de8",
                    SpeakerIds = new List<string> { "95f608f7-650d-412b-96a3-d675bdf114b6" },
                    SessionType = "Workshop",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> { "Career skills", "Web" },
                    StartTime = new DateTime(2019, 10, 20, 13, 0, 0),
                    EndTime = new DateTime(2019, 10, 20, 16, 0, 0),
                    Room = "Balkan Buzludzha + Balkan Botev | 6th Floor",
                    Description = "This is open to anyone who identifies as a woman and wants to learn about Vue.js. No previous knowledge of Vue.js is required to attend this event and we invite women of all ages, skill levels and backgrounds to join us. Come learn with us & build something fun!"
                },

                // MONDAY

                new Session
                {
                    Title = "Let’s Build an App with React",
                    Id = "55b35594-6b33-49f9-a94b-eb50e3fbf87b",
                    SpeakerIds = new List<string> {"4341d469-0fd7-4061-94b7-8e466e7259b9", "ba7953fe-a806-4541-b29a-aa901676d98f"},
                    SessionType = "Workshop",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Web", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 21, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 21, 16, 0, 0),
                    Room = "Balkan Buzludzha | 6th Floor",
                    Description = "This workshop is for developers wanting a crash-course in React. It will teach you how to build a real-world web application through a hands-on approach. Through step-by-step instructions, you’ll learn how to build a responsive application leveraging various React concepts, including JSX, elements, and components. You will learn how to manage component state and understand the component lifecycle. Other concepts like events, conditional rendering, forms, hooks will be covered in great detail. What’s more, you will gain a deep understanding of the ecosystem (including tools) that exists to help you build web applications with React. After completing this workshop, you will have the confidence to apply what they learn into future development tasks and opportunities.\r\n\r\n\r\nCurriculum: \r\nWorkshop Overview\r\n1.1.Expectations and Outcomes\r\n1.2.Application Overview\r\n1.3.Workshop Resources\r\nAn Introduction to React\r\n2.1.Motivation\r\n2.2.Core Concepts\r\n2.3.Tooling\r\n2.3.1.Create React App (CRA), StackBlitz.com\r\n2.3.2.Dependencies and Package Management\r\n2.4.Basic Tutorial\r\n2.5.React Resources\r\nBuild Web App\r\n3.1.Hooks in React\r\n3.2.State Management with Hooks and Reducers\r\n3.3.Testing/Mocking (tooling)\r\n3.4.Deployment (webpack)\r\n3rd Party Component Integration\r\n4.1.Overview of React Component Ecosystem\r\n4.2.Integrate KendoReact Grid into Master-Detail\r\nThemes and Accessibility\r\n \r\n\r\nBreakdown:\r\n9 AM: Introductions and workshop overview\r\n9:15 AM: An Introduction to React\r\n10 AM: 15-minute break\r\n10:15 AM: Build Web App\r\n12 PM: Lunch break\r\n1 PM: Resume Build Web App\r\n2 PM: 3rd Party Component Integration\r\n3 PM: Themes and Accessibility\r\n3:45 PM: Wrap Up\r\n4 PM: Finish"
                },
                new Session
                {
                    Title = "Build a Sitefinity Application in a Day",
                    Id = "33cd7e16-301e-4785-aee5-2fb7657d60e2",
                    SpeakerIds = new List<string> { "e72da88e-f9c5-48e1-b774-c4e7e0b51a76" },
                    SessionType = "Workshop",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> { "Web", "Tools/Frameworks" },
                    StartTime = new DateTime(2019, 10, 21, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 21, 16, 0, 0),
                    Room = "Baba Marta | 7th Floor",
                    Description = "In this workshop, we will build a fully functional Sitefinity application with Bootstrap templates, custom MVC widgets, security and deployment to Azure Cloud. Customizations with Tips and Tricks will be demonstrated throughout the day to get comfortable with what we believe is the best CMS system on the market. Bring your laptop and a trial license of Sitefinity, and let's have hands-on fun!\r\n\r\nTopics covered:\r\n\r\nMVC Widget Development\r\nCustom Designers with Angular\r\nBootstrap layout management\r\nRazor Templates for MVC Widgets\r\nStandard API, Fluent API and ODATA API\r\nConfiguration sections\r\nEventHub for intercepting events\r\nCustom Modules and Dynamic Types\r\nBest use of SiteSync\r\nTips and Tricks for Optimization and Performance\r\nDeployment to Azure Tips & Tricks."
                },
                new Session
                {
                    Title = "Build your First Full-stack Blazor App",
                    Id = "7122b111-0bbb-48b8-8e65-0d63cabe1302",
                    SpeakerIds = new List<string> {"472f59a9-585a-488c-8ffa-637e1490f43b", "bced2e9a-f1c4-4ecd-9fd4-bc76935287b2"},
                    SessionType = "Workshop",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Web", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 21, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 21, 16, 0, 0),
                    Room = "Balkan Shipka + Balkan Kom | 6th Floor",
                    Description = "The arrival of WebAssembly begins a new era for .NET web developers, allowing client-side applications written in C# to run directly in the browser. Blazor is a newly emerging client-side UI platform from the ASP.NET Core team, offering a productive and powerful way to construct large-scale applications with a modern component-based architecture. It integrates with the wider.NET ecosystem to enable truly full-stack client+server development on a single language and runtime, based on modern standards, and able to run in any browser (including mobiles).\r\n\r\nThis workshop will quickly take you from getting started with Blazor basics, right through to building sophisticated UIs using more advanced framework features. We’ll explore not only the capabilities of Blazor and WebAssembly today, but also the longer-term vision for the future of web apps on .NET.\r\n\r\n\r\nIMPORTANT Prerequisites\r\n\r\n** YOU MUST FOLLOW THESE INSTRUCTIONS TO PARTICIPATE **\r\n\r\nWe can’t stress enough that you need to install the next 3 items in order to participate in the workshop. If you do not use the guide below, you may be pairing up with someone else who did.\r\n\r\n \r\n\r\n1. Install Visual Studio 2019 Preview (latest update)\r\n\r\nInstall the PREVIEW edition of Visual Studio 2019. Community edition or higher is acceptable as long as it is preview. Visual Studio 2019 (RTM) does not contain all of the tooling needed and support for Visual Studio Code is spotty at best. The installer can be found here: https://visualstudio.microsoft.com/vs/preview/\r\n\r\n \r\n\r\n2. ASP.NET Core 3.X Preview X (latest version)\r\n\r\nInstall the .NET Core 3.X Preview X release. Blazor WebAssembly is also in preview and requires the latest release to work properly. The installer for x64 and x86 can be found here: https://dotnet.microsoft.com/download/dotnet-core/ If you don’t know what installer to grab, the “.NET Core Installer: x64” is most common."
                },
                new Session
                {
                    Title = "Empower Women",
                    Id = "e862f370-8336-4fdb-995b-4f3059f95bfb",
                    SpeakerIds = new List<string> {"4cb00fa7-e657-4209-b2fc-29f142ced977", "0f3125d3-9618-4e7e-98ae-f60c3a9fdf0b", "7354065a-d8ff-477e-94ea-c61a84fb1cc0"},
                    SessionType = "Workshop",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Career skills"},
                    StartTime = new DateTime(2019, 10, 21, 11, 0, 0),
                    EndTime = new DateTime(2019, 10, 21, 17, 0, 0),
                    Room = "Balkan Botev | 6th Floor",
                    Description = "This is a session description."
                },

                // TUESDAY

                new Session
                {
                    Title = "Welcome & Opening Comments",
                    Id = "888642c1-fc36-48a6-a92f-803dd381ed88",
                    SpeakerIds = new List<string> {"34b73482-ca92-421d-a9e7-2c4367d27904", "7354065a-d8ff-477e-94ea-c61a84fb1cc0"},
                    SessionType = "",
                    Technology = new List<string>(),
                    Topic = new List<string>(),
                    StartTime = new DateTime(2019, 10, 22, 8, 45, 0),
                    EndTime = new DateTime(2019, 10, 22, 9, 0, 0),
                    Room = "Keynote Hall"
                },
                new Session
                {
                    Title = ".NET: To Infinity and Beyond",
                    Id = "cfc87d90-689e-4a6a-aefe-183c76fb0d32",
                    SpeakerIds = new List<string> {"161dc9b0-078b-47c5-9b89-ee1510cd1b1c"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Smarter Apps", "Smarter Apps", "Mobile","Web","Desktop", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 22, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 22, 9, 45, 0),
                    Room = "Keynote Hall",
                    Description = "As the software development industry moves at a blazing fast pace so does .NET. .NET leads the way across a multitude of platforms including web, IoT, desktop, mobile, wearables, and so many more. In this session we will take you through the journey of a .NET developer creating apps for these platforms on Visual Studio 2019 and Visual Studio 2019 for Mac. You will see how the latest advancements in .NET with the Mono Interpreter enable new scenarios for WebAssembly, iOS and Android development, and more. If you are .NET developer, you do not want to miss this .NET packed session as .NET truly goes everywhere."
                },
                new Session
                {
                    Title = "Uno Platform: Your C#/XAML Apps on Mobile &WebAssembly",
                    Id = "f6a6aeab-b46a-40e9-ac57-89ccf700b094",
                    SpeakerIds = new List<string> {"52da761a-8d3b-46d4-a186-50ddfa89f484"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> { "Mobile", "Web", "Tools/Frameworks" },
                    StartTime = new DateTime(2019, 10, 22, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 10, 20, 0),
                    Room = "Panorama",
                    Description = "Developing cross-platform applications is complex. Some frameworks allow us to share the business logic layer. Some go further and allow us to share the UI layer, usually limited to the lowest common denominator. But even then – working with device hardware still requires not only error-prone platform-specific code but also developers familiar with each of the target platforms to maintain it. What if there was a framework, which would allow you to write all your code in C#/XAML, with full styling and templating capabilities, with a single API to access device hardware? Meet the Uno Platform - your C#/XAML apps on Android, iOS, and WebAssembly!"
                },
                new Session
                {
                    Title = "10 Awesome Things You Can Build with NativeScript",
                    Id = "26c914cd-24bf-4c8a-8347-4e1bc1a96b4b",
                    SpeakerIds = new List<string> {"d944d7ed-64b5-4534-b1cf-a8734c3662c1"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Tools/Frameworks", "Mobile", "Smarter Apps"},
                    StartTime = new DateTime(2019, 10, 22, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 11, 20, 0),
                    Room = "Gamma",
                    Description = "NativeScript makes it easy to build cross-platform iOS and Android apps that take advantage of the best of what mobile platforms have to offer.\r\nIn this talk you’ll learn how to use NativeScript to implement cutting-edge mobile features like augmented reality, wearables, and facial recognition—and you’ll do all of that using technologies familiar to JavaScript developers, like TypeScript and CSS.\r\nCome learn what’s possible to create in mobile apps today, and how to build these apps yourself using NativeScript."
                },
                new Session
                {
                    Title = "An Introduction to WebAssembly",
                    Id = "15dbc6b7-2eae-42d0-8d4e-fe8dc90b2b78",
                    SpeakerIds = new List<string> {"0491fc8a-9975-415b-8eb6-d9d073e66641"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Web"},
                    StartTime = new DateTime(2019, 10, 22, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 11, 20, 0),
                    Room = "Alpha",
                    Description = "Want to write a web application? Better get familiar with JavaScript! JavaScript has long been the king of front-end. While there have been various attempts to dethrone it, they have typically involved treating JavaScript as an assembly-language analog that you transpile your code to. This has lead to complex build pipelines that result in JavaScript which the browser has to parse and you still have to debug. But what if there were an actual byte-code language you could compile your non-JavaScript code to instead? That is what WebAssembly is.\r\n\r\nI'm going to explain how WebAssembly works and how to use it in this talk. I'll cover what it is, how it fits into your application, and how to build and use your own WebAssembly modules. And, I'll demo how to build and use those modules with both Rust and the WebAssembly Text Format. That's right, I'll be live coding in an assembly language. I'll also go over some online resources for other languages and tools that make use of WebAssembly.\r\n\r\nWhen we're done, you'll have the footing you need to start building applications featuring WebAssembly. So grab a non-JavaScript language, a modern browser, and let's and get started!"
                },
                new Session
                {
                    Title = "What’s New in ASP.NET Core 3.0",
                    Id = "ad1c0d80-fdec-48ef-bdae-be4b17c5aed2",
                    SpeakerIds = new List<string> {"d0aeb34d-2010-4ea8-8fc4-9a319d7abebd"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Tools/Frameworks", "Web"},
                    StartTime = new DateTime(2019, 10, 22, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 11, 20, 0),
                    Room = "Beta",
                    Description = "Worker Services, gRPC and native JSON support - oh my! ASP.NET Core 3.0 is chock-full of features for building modern web apps and services. But what else is in store for this release? More importantly, what does the 3.0 release mean for your existing ASP.NET Core 2.x app? Jump aboard for a code-heavy tour of the latest in ASP.NET Core. Leave the session with tips for upgrading from ASP.NET Core 2.x to 3.0, and knowledge of which features & enhancements will pay dividends in your app."
                },
                new Session
                {
                    Title = "Write High Quality Maintainable Code",
                    Id = "bcd736ca-3240-400f-b808-d0f195e44462",
                    SpeakerIds = new List<string> {"ff01e002-64c9-4e4f-9cc4-699003a6f508"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> { "Career skills", "Processes"},
                    StartTime = new DateTime(2019, 10, 22, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 12, 20, 0),
                    Room = "Panorama",
                    Description = "Do you want to take your development skills to the next level? Do you want to write high quality, maintainable, reusable, and extensible code? In this session, we’ll look at what is high quality code. You’ll learn how to take on the right amount of technical debt, how processes like Agile can help or harm a project, what to do about all the patterns out there, how SOLID helps development, and many techniques for making code better and healthier. Topics from the very basic (but so hard), naming to the complex is covered here."
                },
                new Session
                {
                    Title = "Let’s Build an Augmented Reality Football Pitch with JavaScript!",
                    Id = "29ade675-370a-48d7-b1c9-f1df4d6cb0e5",
                    SpeakerIds = new List<string> {"e506d98a-bfd1-473f-84c7-67fef6facfd3"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Tools/Frameworks", "Mobile", "Smarter Apps"},
                    StartTime = new DateTime(2019, 10, 22, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 12, 20, 0),
                    Room = "Gamma",
                    Description = "With the introduction of Augmented Reality (AR) capabilities on both iOS an Android, developers can start using AR APIs to create a new wave of innovative and engaging mobile apps. And yes, a lot of really useless stuff! Let's take a brief look at the history of AR, some prime examples of AR in use today (the good and the bad), how the ARKit and ARCore APIs work, and how you can use NativeScript to build some awesome cross-platform AR apps with JavaScript and Angular or Vue.js."
                },
                new Session
                {
                    Title = "RESTful API Best Practices using ASP.NET Core Web API",
                    Id = "aeb98552-df8c-4b30-87aa-3b8804d5b78a",
                    SpeakerIds = new List<string> {"47ecdb2c-a27e-42d3-a8aa-74f2bebd04dd"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Tools/Frameworks", "Web"},
                    StartTime = new DateTime(2019, 10, 22, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 12, 20, 0),
                    Room = "Beta",
                    Description = "Designing and building RESTful APIs isn’t easy. On its surface, it may seem simple – after all, developers are only marshaling JSON back and forth over HTTP, right? Believe it or not, that’s only a small part of the equation. There are many things to keep in mind while building the systems that act as the key to your system.\r\n\r\nIn this session, we’ll delve into several best practices to keep in mind when designing your RESTful API. Attendees will learn about authentication, versioning, controller/model design, testability, documentation and change management. This session will also explore the do’s and don’t’s of RESTful API management so that you make sure your APIs are simple, consistent, and easy-to-use.\r\n\r\nExamples will be done using ASP.NET Core Web API and C#. However, this session will benefit anyone who is or might be working on a RESTful API."
                },
                new Session
                {
                    Title = "Hacking the Human Perception",
                    Id = "9f279340-810a-4950-ad42-45f386c38f90",
                    SpeakerIds = new List<string> {"952f0bde-472e-49dc-8b23-eaaf8a1ec62b"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Web"},
                    StartTime = new DateTime(2019, 10, 22, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 12, 20, 0),
                    Room = "Alpha",
                    Description = "Hacking you say? Yes, I do, but this type of hacking has nothing to do with hooking in Matrix style or surfing through The Gibson at Ellingson Mineral Company. Nope, this type of hacking involves how we as developers, create the illusion of fast load times for our Web applications. Performance is gaining much visibility in the industry and catering to the needs of the user, there are many things we can do to facilitate that need. This talk will focus on ways we can make things appear to be faster than they are and ways to avoid having to play Houdini entirely."
                },
                new Session
                {
                    Title = "NGRX - Predictable Reactive State Management for Enterprise Angular Apps",
                    Id = "0e90f561-d3ae-449b-a4d0-1e9cd14acbaf",
                    SpeakerIds = new List<string> {"aede7a28-6aca-49e6-a417-2a828acee88c"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Tools/Frameworks", "Web"},
                    StartTime = new DateTime(2019, 10, 22, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 14, 20, 0),
                    Room = "Alpha",
                    Description = "Good state management is key to the stability and efficiency of any web application. Redux has established itself as the de facto standard in handling State Management on the web and in this talk Iliya Idakiev will share his knowledge of designing and using NGRX, a platform that combines the Redux pattren with the Reactive Extension for JavaScript to produce one of the best ways for handling state in big Angular applications."
                },
                new Session
                {
                    Title = "Developing for HoloLens",
                    Id = "84761bed-4b40-4dc6-ba24-cd39ebdc1abe",
                    SpeakerIds = new List<string> {"2a205aa0-f286-46d7-84d8-9873974450d1"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Tools/Frameworks", "Smarter Apps"},
                    StartTime = new DateTime(2019, 10, 22, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 14, 20, 0),
                    Room = "Gamma",
                    Description = "Have you ever wished you could hold the Tesseract in your hand? Perhaps even become a real world Tony Stark? Using HoloLens and Unity we can create an experience that lets you bring digital content into real world.\r\n\r\nDuring this session, I will talk about the HoloLens 2 hardware, the possibilities, the limitations, and tooling. We will create a HoloLens app from scratch complete with Gaze, Air Tap, Spatial mapping and Voice using Mixed Reality Toolkit.\r\n\r\nAnd we will touch on the new Azure services - Spatial Anchor and Remote Rendering. Fun!"
                },
                new Session
                {
                    Title = "SignalR: Above & Beyond Chat",
                    Id = "4dfd1bb5-0064-4dbb-a58a-821d3204b3de",
                    SpeakerIds = new List<string> {"1caef8d2-bdc3-4f96-b069-a566af3c2c7f"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Web"},
                    StartTime = new DateTime(2019, 10, 22, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 14, 20, 0),
                    Room = "Beta",
                    Description = "If you're unfamiliar with the term \"SignalR\", don't stray away... this helpful technology could save your day. SignalR boasts real-time web functionality which enables server-side code to push content to clients instantly. In this talk, we'll start with a simple Chat application so that we understand the mechanics. Then we'll dive deeper into other use cases and we'll explore the various protocols. We'll cover how SignalR can be applied to Angular, VueJS and even Blazor. Expect to walk away from this talk knowing exactly how to use SignalR in your application and why it is so useful."
                },
                new Session
                {
                    Title = "Hacking the Domain with Domain-Driven Design",
                    Id = "0ff26b79-5c4b-4c69-a092-9e48c74b26b3",
                    SpeakerIds = new List<string> {"f9ca6d07-6f5d-4881-abf9-b65e4ead1337"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> { "Processes", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 22, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 14, 20, 0),
                    Room = "Panorama",
                    Description = "The domain sits at the core of business software and yet it is often ignored resulting in anguish among developers, users, and business folks. Correctly distilling the principles of a domain in many cases predetermines the success or failure of a software project. Unfortunately, over the years we have lost the ability to truly capture domains for a myriad of reasons. One of those is that it takes effort to crack a domain and fully understand it but that’s where the prize money is.\r\n\r\nThis talk will demonstrate how we as developers can utilize the power of Domain-Driven Design (DDD) to understand and correctly capture domain knowledge in our code. We will learn how this reduces friction with the business, eliminates feature gaps, and leads to secure and testable software systems. Inevitably we will cover the fundamental concepts in DDD and pave the path forward to writing better business software."
                },
                new Session
                {
                    Title = "Alexa - Top Me Up",
                    Id = "1e510368-069e-4a36-9683-a95baab2895b",
                    SpeakerIds = new List<string> {"c4d1bddd-e096-4a7d-a7a1-9773a86d6c55"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> { "Smarter Apps", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 22, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 15, 20, 0),
                    Room = "Gamma",
                    Description = "In the last few years, voice assistants changed the way we interact with our devices. Many find them more natural to talk to their devices than to type. But how do you build one?\r\n\r\nJoin me to learn how to build your own Alexa skill with Kinvey Chat. We will build a chatbot that will help the customers of C-Mobile check their balance and top up their phones.\r\n\r\nExpect a lot of fun, many misunderstandings and to learn enough to build your own Alexa skill, and that is a Sebbie promise 😉."
                },
                new Session
                {
                    Title = "Will Writing Unit Tests be Replaced by Artificial Intelligence?",
                    Id = "1369083c-5727-456e-8f69-ee6a88711cfc",
                    SpeakerIds = new List<string> {"864224c2-65ce-4e71-87f0-8c51a2420ccf"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Smarter Apps", "Processes"},
                    StartTime = new DateTime(2019, 10, 22, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 15, 20, 0),
                    Room = "Panorama",
                    Description = "In this session, we will talk about where we currently stand in terms of the available tools and difficulties we face for writing unit tests. We will dive into the topic of emerging artificial intelligence based tools for writing code. Next, we will discuss how this is relevant for the unit tests topic and will continue with the challenges and problems of generating tests with AI and discuss the options for solving them."
                },
                new Session
                {
                    Title = "Razor: Into the Razor-Verse",
                    Id = "10b893c3-707d-48fe-a555-da18e93a1281",
                    SpeakerIds = new List<string> {"bced2e9a-f1c4-4ecd-9fd4-bc76935287b2"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> { "Web" },
                    StartTime = new DateTime(2019, 10, 22, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 15, 20, 0),
                    Room = "Beta",
                    Description = "The Razor template markup syntax is used throughout ASP.NET. In the next version of ASP.NET, Core Razor is evolving into multiple Razor adaptations such as Razor Tag Helpers, Razor Pages, Blazor, Razor Components and Razor Circuits. In this session, we'll learn the key differences between theses variations and see where they align in the ASP.NET road map. We’ll make sense of how each concept was introduced and what use cases they fulfill."
                },
                new Session
                {
                    Title = "Enterprise Mobile Architectures with Xamarin.Forms & Prism",
                    Id = "a1a0cc4d-aec8-4969-9384-d0c167a50577",
                    SpeakerIds = new List<string> {"fdbb3ef8-9761-4a14-aa55-9a9555cbfa58"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Mobile", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 22, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 22, 15, 20, 0),
                    Room = "Alpha",
                    Description = "Developing apps can be hard, there's a lot to learn to start developing apps. When working in Enterprise or Team environments though, the complexities just start compounding. How do you reuse components from one app to the next? How can you have multiple developers or teams working on an app without constantly running into Merge Conflicts? We'll look at how you can harness the tremendous code sharing power of Xamarin.Forms together with Prism library to architect beautiful and loosely coupled apps that are Enterprise Ready."
                },
                new Session
                {
                    Title = "Lessons Learned from Sitefinity Cloud",
                    Id = "bc89e3d2-a6f1-4db1-9094-d18d50161650",
                    SpeakerIds = new List<string> { "bad65784-fe93-457f-b23b-3e0d3593f380" },
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Processes"},
                    StartTime = new DateTime(2019, 10, 22, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 16, 30, 0),
                    Room = "Panorama"
,                   Description = "Building a new cloud offering for an existing product is exciting but very challenging. How do we define our offering package? How do we define the required infrastructure and measure performance? How do we enable DevOps platform self-service for our customers? Join us to see how we built Sitefinity Cloud in Microsoft Azure from scratch and in record time."
                },
                new Session
                {
                    Title = "DevOps Practices Can Make You a Better Developer",
                    Id = "12b4b0c4-9504-40ec-ad2b-617b707f2c8b",
                    SpeakerIds = new List<string> {"1a6057f3-5941-41eb-b3fc-f9bc29be10f1"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", ".NET" },
                    Topic = new List<string> {"Processes", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 22, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 16, 30, 0),
                    Room = "Beta",
                    Description = "Improved deployment frequency. Faster time to market. Lower failure rates. Faster fixes and recovery time. These are some of the promises of DevOps. Whether you are an individual developer or working in a team, you can take advantage of DevOps practices. In this session, aimed at developers who are new to DevOps, you'll see how you can leverage the concepts of agile development, continuous integration and continuous delivery to build better software. And you'll see how Visual Studio and Azure DevOps provide you with the tools you need."
                },
                new Session
                {
                    Title = "Why Every Web App Should be a PWA",
                    Id = "181eaf12-dfaf-4daa-a402-2b270679044a",
                    SpeakerIds = new List<string> {"055f8bd3-ea18-4c72-9ded-b31b0cf4a5a1"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Web"},
                    StartTime = new DateTime(2019, 10, 22, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 16, 30, 0),
                    Room = "Alpha",
                    Description = "In this session, we will cover what makes a PWA great, lessons we can learn from PWAs that can apply to any application, and reasons why every web app should be a PWA. How many times have you tapped on a link when browsing the web on your mobile device only to sit there for what feels like an eternity before it loads? Is the bounce rate of mobile users of your website through the roof? We might just think about Progressive Web Apps (PWAs) as web apps with some native capabilities on mobile devices, but they are so much more; they are a way of thinking that helps make the mobile web be less terrible."
                },
                new Session
                {
                    Title = "Advanced Fiddler Techniques",
                    Id = "8b8ed987-2fd9-42f5-b283-72210b195a33",
                    SpeakerIds = new List<string> {"c5d27676-e04a-418e-9eef-79ced0da01a2"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Web"},
                    StartTime = new DateTime(2019, 10, 22, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 16, 30, 0),
                    Room = "Gamma",
                    Description = "Telerik Fiddler is a great free web diagnostic tool that nearly everyone uses, but typically only for very basic things. If all you need is to see the requests made between the browser and web server, the browser DevTools can do that. Fiddler has many more advanced features that most developers are unaware of. It can be used to capture traffic from smartphones, tablets, and non-Windows platforms! Discover the power of manipulating requests and responses with breakpoints, the auto responder, and a visual composer. Review popular extensions for formatting JavaScript, syntax highlighting, and detecting image bloat. Go beyond the basics and learn the full capabilities of the tool and how it can improve your web development and debugging techniques today!"
                },
                new Session
                {
                    Title = "Mastering Sitefinity Consulting: Lessons Learned",
                    Id = "289248fd-66ae-476b-830e-2718ceb95aed",
                    SpeakerIds = new List<string> {"da11ff42-1555-49e4-8bae-c2c845dcc5a1"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Processes", "Web"},
                    StartTime = new DateTime(2019, 10, 22, 16, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 17, 30, 0),
                    Room = "Panorama",
                    Description = "This is partly technical, partly soft skills presentation with real-world client examples for best advice on how to tackle the regular: \"We don't think Sitefinity was a good choice\", when the real problem is in fact the implementation of the specific website and not the product. I am also going to share top asked questions during trainings that I am leading all over the world on behalf of Progress, funny stories on culture differences and some technical tips & tricks."
                },
                new Session
                {
                    Title = "VR Quickstart with Unity 3D",
                    Id = "0cb8c69c-1b3a-42b5-ba3e-ae008ec04fee",
                    SpeakerIds = new List<string> {"9bd0ffee-a53a-4bba-9ca6-d315555d0639"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Tools/Frameworks","Smarter Apps"},
                    StartTime = new DateTime(2019, 10, 22, 16, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 17, 30, 0),
                    Room = "Alpha",
                    Description = "Have you ever explored the virtual reality world? Are you a C# fan? Are you curious how to build your own app for virtual reality?\r\n\r\nIn this session you will see how to apply your C# skills, into building your first virtual reality app, using Unity3D. We will iron out some of the peculiarities of the game development framework, nail down the VR UI and interactions, while building something useful."
                },
                new Session
                {
                    Title = "Functional Programming for C# Developers",
                    Id = "90c7ea62-6675-42b5-87f0-68856c87d135",
                    SpeakerIds = new List<string> {"5912e378-6cd7-483b-b9fa-e27b1ab3bac2"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 22, 16, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 17, 30, 0),
                    Room = "Beta",
                    Description = "This will be a session which will discuss how C# developers can deliver more robust, maintainable and high quality code by borrowing some concepts and principles from the functional programming world and how the C# language supports them. The talk will combine both practical applications of FP and the theory behind of why they work and improve things.\r\n\r\nKey Takeaways:\r\n\r\nYou will learn what's behind the growing interest in functional programming and what's so great about it\r\nYou will get to know how to combine Object-Oriented paradigms with Functional-Programming ones effectively\r\nYou will be able to identify common problems with traditional procedural code and how to refactor them\r\nYou will leave with a new mindset about how to design the flow of your app"
                },
                new Session
                {
                    Title = "Feed Your Inner Data Scientist: JavaScript tools for Data Visualization & Filtering",
                    Id = "361af3d1-8714-42a8-b829-90f793472b96",
                    SpeakerIds = new List<string> {"a36183d8-0192-4314-8bc6-3d0a815a746a"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Web", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 22, 16, 40, 0),
                    EndTime = new DateTime(2019, 10, 22, 17, 30, 0),
                    Room = "Gamma",
                    Description = "It seems like every day a new JavaScript framework becomes popular. It can be overwhelming keeping up with them. This session will discuss some JavaScript libraries that makes analyzing and displaying data a snap. We will discuss D3.js, CrossFilter.js, DC.js and jQuery DataTables. These are very robust community supported libraries. Use them in your client application to add interactive visualizations and data analysis tools."
                },

                // WEDNESDAY

                new Session
                {
                    Title = "Opening Comments",
                    Id = "7552e32c-d444-4272-94ce-401792a5b2dc",
                    SpeakerIds = new List<string> {"34b73482-ca92-421d-a9e7-2c4367d27904"},
                    Technology = new List<string>(),
                    Topic = new List<string>(),
                    StartTime = new DateTime(2019, 10, 23, 8, 45, 0),
                    EndTime = new DateTime(2019, 10, 23, 9, 0, 0),
                    Room = "Keynote Hall"
                },
                new Session
                {
                    Title = "Technical Leadership: Lessons Learned at NASA",
                    Id = "1d68718e-7b3a-4e91-b506-916c1a240285",
                    SpeakerIds = new List<string> {"4cb00fa7-e657-4209-b2fc-29f142ced977"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Processes","Career skills"},
                    StartTime = new DateTime(2019, 10, 23, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 23, 9, 45, 0),
                    Room = "Keynote Hall",
                    Description = "This talk focuses on important aspects of technical leadership and lessons learned in NASA engineering, missions and projects that can be applied to any STEM career or leadership position. Interpersonal skill development is highlighted along with best practices in key areas of innovation and diversity. Exciting experiences are also shared from large NASA missions such as Mars Science Laboratory and James Webb Space Telescope, as well as unique personal experiences pertaining to challenge and growth that can be applied to technical leadership."
                },
                new Session
                {
                    Title = "I Can't See: Low Vision A11y & Users",
                    Id = "e3bb657a-7a6c-4c00-9a01-c29fa0c114cf",
                    SpeakerIds = new List<string> {"952f0bde-472e-49dc-8b23-eaaf8a1ec62b"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> { "Design/UX" },
                    StartTime = new DateTime(2019, 10, 23, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 11, 20, 0),
                    Room = "Panorama",
                    Description = "When you think of low vision, what comes to mind? A user that is near sighted? How about far sighted? Maybe partially blind? These are all qualifying cases of poor vision, but low vision is more complicated than the prescription of glasses or contacts.\r\n\r\nAccording to the World Health Organization, they categorize low vision based on specific levels of visual acuity and field of vision (W3.org, 2016). With that in mind, we as developers can look at different categories of low vision including color vision, visual acuity, contrast sensitivity, etc and make an effort to bake in things like zoom, non-conflicting colors, and re-wrapping of columns in to our code.\r\n\r\nMy talk will cover what vision accessibility is, different categories of low vision, what the needs of the users are, and what we as developers can do to achieve a great user experience for low vision users."
                },
                new Session
                {
                    Title = "Go Mobile with Xamarin",
                    Id = "faa9734c-b82f-4dc3-a7d8-066b69a0f028",
                    SpeakerIds = new List<string> {"161dc9b0-078b-47c5-9b89-ee1510cd1b1c"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Tools/Frameworks", "Mobile"},
                    StartTime = new DateTime(2019, 10, 23, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 11, 20, 0),
                    Room = "Beta",
                    Description = "Xamarin enables C# developers to become native iOS, Android, and Windows mobile app developers overnight. In this session, you will learn how to leverage your existing .NET and C# skills to create iOS and Android mobile apps in Visual Studio with Xamarin. In addition to allowing you write your iOS and Android apps in C#, Xamarin lets you reuse existing .NET libraries and share your business logic across iOS, Android, and Windows apps. This session will also give you the tools to determine how much existing C# code can go mobile to iOS and Android, plus help you determine the architecture necessary to support maximum code sharing and reuse. We will also provide guidance and best practices for handling fragmentation across and within each device platform.\r\n\r\nDuring this session we will cover the Xamarin platform and how to create native iOS, Android, and Windows apps in C#. Moreover, we will really focus on the code with several live coding adventures throughout the entire session. When you leave you will have the knowledge to create your first iOS & Android in C# with Xamarin in Visual Studio."
                },
                new Session
                {
                    Title = "How to Improve Your UX with a Deck of Cards",
                    Id = "3e7ed8d1-fd6b-4ac0-b65c-e4c3084c9fae",
                    SpeakerIds = new List<string> {"e6a12a4c-5e19-4208-84a4-50e1d48c7490"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Design/UX"},
                    StartTime = new DateTime(2019, 10, 23, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 11, 20, 0),
                    Room = "Gamma",
                    Description = "In this session you will learn easy and comprehensible steps to catch the most common UI/UX problems, why they are a problem and how to fix them.\r\n\r\nThis no-fluff-easy-to-comprehend-system is perfect for developers and everyone else who wants to give their user the best experience possible."
                },
                new Session
                {
                    Title = "State Management with React Hooks",
                    Id = "84e517dd-15af-4c0d-b447-a71d33c2bbd7",
                    SpeakerIds = new List<string> {"4341d469-0fd7-4061-94b7-8e466e7259b9"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> { "Web","Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 23, 10, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 11, 20, 0),
                    Room = "Alpha",
                    Description = "Managing state for UI components in React has required a dependency on libraries like Redux until now. React has introduced Hooks and this talk covers the basics of state and side-effects using React Hooks (useState, useEffect, and useReducer). The session will also demonstrate how to integrate KendoReact and its themes into a real world application."
                },
                new Session
                {
                    Title = "Low Friction Front End Development with StackBlitz",
                    Id = "0a56a340-f003-4b72-abd9-396b2b52be0e",
                    SpeakerIds = new List<string> {"7ad86657-7ffc-459d-8d87-529e996835f6"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Tools/Frameworks", "Web"},
                    StartTime = new DateTime(2019, 10, 23, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 12, 20, 0),
                    Room = "Beta",
                    Description = "Getting started with front end development can be intimidating - so many frameworks and libraries seem worthy of at least trying out! Even for a seasoned developer, just installing the tooling and dependencies can be a pain in the neck. It doesn’t have to be! Let’s see how you can use StackBlitz to have our IDE available instantly - in a browser.\r\n\r\nAgenda:\r\n\r\n- Introduction + State of developing frontend applications\r\n- StackBlitz capabilities: working with frameworks, dependencies and git\r\n- A typical workflow (demo)\r\n- Questions"
                },
                new Session
                {
                    Title = "Demystifying User Management for Voice Apps",
                    Id = "e9d02da5-c44a-4c12-ae16-7a080559f7e7",
                    SpeakerIds = new List<string> {"a995eb1b-7405-413c-967f-268f327fdfef"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Smarter Apps", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 23, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 12, 20, 0),
                    Room = "Gamma",
                    Description = "Many voice skills can be built for anonymous users, but it takes an additional step to authenticate and track known ones. In this talk, we go over all the steps you need to link Google and Amazon customers to your voice skill and match them to existing users in your database. From account linking to database integration, it’s all covered here. Finally, learn to create and track new users who discover your voice app through Alexa and Google Assistant. Features ASP.NET code and Azure hosting."
                },
                new Session
                {
                    Title = "The Science, Psychology and Secrets of Great UI",
                    Id = "4bf11682-15cc-4c55-bf99-777b565af6d8",
                    SpeakerIds = new List<string> {"d4379470-69bf-4adb-bb31-d87dfa917777"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript", ".NET" },
                    Topic = new List<string> {"Design/UX"},
                    StartTime = new DateTime(2019, 10, 23, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 12, 20, 0),
                    Room = "Alpha",
                    Description = "Need to improve user experience, but don't know where to start? Worried that UI/UX can only be done by right-brained, artistic people? Take heart. Learn simple yet powerful UX principles and UI tricks that will help you radically improve your digital products. These secrets are perfectly suited for logical, left-brain, development professionals. What’s more, you can put them into practice now. Esoteric mathematical equations included at no extra cost.\r\n\r\nWhat You’ll Learn\r\n\r\nGreat UI is quantifiable, measurable, fact-based, and objective.\r\nWhy UX pros care so much about white space, padding, consistency, color choice, layout and all that other stuff that drives you crazy.\r\nHow to argue effectively with the UX people and stakeholders in your life.\r\nHow to notice bad UI on your own, and how to fix it whether or not you work with a UX pro.\r\nUnderstanding how our brains work makes us better digital product designers.\r\nWhat We’ll Do\r\n\r\nExplore practical UI Examples (Good, Bad, and Ugly)\r\nConquer a “Good UI/Bad UI” Quiz (Prizes included)\r\nReceive Resources for Further Study\r\nQ/A and Discussion\r\nWho is it for?\r\n\r\nFront-End and Back-End Developers willing to step outside their comfort zones to ensure their hard work and tireless effort are presented to users in the BEST way possible"
                },
                new Session
                {
                    Title = "Modernization of .NET Desktop Apps",
                    Id = "e9ffdce8-fa19-4f2a-9d54-1c6fcf42ea3b",
                    SpeakerIds = new List<string> {"0164b8f9-c526-4c15-9276-c73314966be3"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Tools/Frameworks", "Desktop"},
                    StartTime = new DateTime(2019, 10, 23, 11, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 12, 20, 0),
                    Room = "Beta",
                    Description = "Yes, you can modernize .NET desktop applications with .NET Core! .NET Core 3 is coming and with it, come many new capabilities for WinForms and WPF applications. Now you can leverage new technologies, such as Windows 10 features, access to device APIs, modern input methods, machine learning, and many more. In this talk I’ll provide an in-depth look at porting desktop applications to .NET Core 3 and cover different ways you can upgrade your WinForms and WPF applications."
                },
                new Session
                {
                    Title = "Inside Our Kitchen: A Recipe for Innovation",
                    Id = "cd5c3094-59a8-4a51-91d4-0298a60bca04",
                    SpeakerIds = new List<string> {"71bc0c81-d5c0-4651-9094-c8d675fb8e87","c1a7953e-688f-42aa-b4b1-9839d5d08a35", "2f89359b-4321-489d-92b3-f806aec8dc7b"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript", ".NET" },
                    Topic = new List<string> {"Tools/Frameworks", "Design/UX"},
                    StartTime = new DateTime(2019, 10, 23, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 14, 20, 0),
                    Room = "Panorama",
                    Description = "Take a peek inside the “kitchen” to see how the Progress team identified the need for a new product, iterated on the idea, and brought it to beta - with all the successes and failures along the way. Then stick around for the hands on lab to be amongst the first to try the product discussed, Unite UX."
                },
                new Session
                {
                    Title = "Be an A11Y. Build Accessible Software for Everyone.",
                    Id = "1f1f5253-73db-4fef-9fa2-1660083d4e1c",
                    SpeakerIds = new List<string> {"ff01e002-64c9-4e4f-9cc4-699003a6f508"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Design/UX"},
                    StartTime = new DateTime(2019, 10, 23, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 14, 20, 0),
                    Room = "Alpha",
                    Description = "Accessible design and programming benefits everyone, not just those with accessible needs. Adding accessibility features into your software opens your software to a 20% increase in market reach (and growing), while making the experience better for everyone. All too often, popular websites and apps fail to design for accessibility, unknowingly resulting in a huge loss their user base, because they simply can’t use the website or app. In business terms, 20% is a whopping number that in the end is some serious cash. And it’s all due to a lack of accessible design.\r\n\r\nIn this session, you’ll learn how to prepare content, design, and program using the techniques that enable those with visual, auditory, motor, or cognitive impairments so those millions of people can now use your apps effectively. You’ll learn to assess what your customer’s accessibility needs are, as well as how to write code with accessibility in mind. You’ll also learn how easy it is to do, with no learning curve. You’ll learn about HTML semantics, ARIA elements, tricks and traps within coding practices to keep in mind while crafting webpages and app layouts."
                },
                new Session
                {
                    Title = "Don't Panic! How to Cope Now You're Responsible for Production",
                    Id = "a8376e01-48f7-4348-a448-b7c8a7d49c57",
                    SpeakerIds = new List<string> {"d7143f9c-ea6b-4d60-ad01-bb3b2f0c425c"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Processes"},
                    StartTime = new DateTime(2019, 10, 23, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 14, 20, 0),
                    Room = "Gamma",
                    Description = "More and more developers are expected to provide out-of-hours support and respond to production issues. If you don't have much experience handling incidents, it can be scary and intimidating - but it doesn’t have to be that way!\r\n\r\n\r\nWe transformed our incident response on the FT's Content team - from a number of terrifying multi-hour outages, to a stable platform where team members feel comfortable on-call.\r\n\r\n\r\nI'll provide practical tips and advice on:\r\n\r\n- planning for the next failure\r\n\r\n- what to do when Everything Is On Fire™\r\n\r\n- improving things afterwards\r\n\r\n- and some horror stories of our own..."
                },
                new Session
                {
                    Title = "Smarter Cross-Platform Apps Using Xamarin, Cognitive Services & ML.NET",
                    Id = "09d54764-f8cb-4b6e-bdad-267dfcff5094",
                    SpeakerIds = new List<string> {"4d07ee99-eb2b-4eeb-9c06-2241310ce3a0"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Smarter Apps", "Mobile","Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 23, 13, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 14, 20, 0),
                    Room = "Beta",
                    Description = "Building “smarter” applications is a popular and important topic in the software development community.  In many cases, machine learning is the primary tool used to create applications that improve their delivered value by dynamically adjusting as more relevant data is made available.  In addition to “smarter” applications, maximizing code re-use by creating cross-platform applications is another popular and important topic among software development professionals. What if you needed/wanted to deliver a cross-platform “smart” application?  Is that possible? \r\n\r\nIn this session, we will explore how to leverage Xamarin, Azure Cognitive Services and ML.NET to create a cross-platform reader that is “smart” and improves (get smarter) as it is used."
                },
                new Session
                {
                    Title = "Progress Unite UX Hands-On Labs",
                    Id = "c689386b-3d18-4844-a42e-82704528cfac",
                    SpeakerIds = new List<string> {"71bc0c81-d5c0-4651-9094-c8d675fb8e87"},
                    SessionType = "Workshop",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> { "Tools/Frameworks", "Design/UX"},
                    StartTime = new DateTime(2019, 10, 23, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 15, 20, 0),
                    Room = "Panorama",
                    Description = "Be amongst the first to try Progress new product hands-on. Unite UX bridges the gap between design and development to reduce iterations by streamlining the handoff from UX to developers. Unite UX introduces Kendo UI sketch libraries that can be easily exported from Sketch and translated directly to Angular or React code in Unite UX. The team that build the product will help you install, get started and work your way from the design in Sketch to building a fully-functioning front-end of a responsive web application."
                },
                new Session
                {
                    Title = "Spotting and Nurturing Technical Leaders",
                    Id = "aabc066f-9ba9-41bc-82bf-678774b27517",
                    SpeakerIds = new List<string> {"903f6f1a-ff07-44d5-8f40-585dd390902d"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Career skills"},
                    StartTime = new DateTime(2019, 10, 23, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 15, 20, 0),
                    Room = "Alpha",
                    Description = "Technical Leads: The people who fuel up an organization's projects by being both technically sane and effective contributors, and also leading their small teams. This first level of leadership is critical to the success of every organization. Lot of people may have mentioned in their careers - \"...but I don't want to manage!\", but still decided to take the road. And after that, excelled not only as such but as a true leader of their team.\r\n \r\nShould we hire our leads from outside our organization? Do we spot them from within our teams, and help them take steps towards excelling into authentic leadership? What are the essential caveats of this critical role in any business, but especially in software development? How do we see these qualities, even when we interview for pure, technical positions? How do we find these among our candidates?\r\n \r\nHow do you become one of these people? What should you do if you'd like to take the first step into leadership career? What are the most common mistakes, which we all made? And how to avoid them?\r\n \r\nIn this presentation, with the help of approximately fifteen years of technical leadership and management on many levels, we'll walk through the challenges which were met, the mistakes that were made, and lessons learned. If you're a professional who's struggling to find the right leadership for your organization, you may find valuable knowledge here.  If you're a professional who'd like to embark on the leadership path, you may want to know what challenges you'll be asked to resolve."
                },
                new Session
                {
                    Title = "Embedding V8 in Real World",
                    Id = "0e5558c6-8d52-4df0-bf19-948d18c70c46",
                    SpeakerIds = new List<string> {"95f608f7-650d-412b-96a3-d675bdf114b6", "a58803d1-02c0-49cf-94bf-62a848d95277"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> { "Mobile", "Web"},
                    StartTime = new DateTime(2019, 10, 23, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 15, 20, 0),
                    Room = "Gamma",
                    Description = "V8 is the JavaScript engine powering Google Chrome, Node.js, and NativeScript.\r\nNativeScript embeds V8 to process JavaScript and dynamically call Android APIs. This enables developers to write Android applications in JavaScript and directly access the underlying OS.\r\nIn this session, we’ll cover various topics based on the experience of the NativeScript team with the V8 engine - from GC synchronization, through implementing a multithreading model, up to practical advice for optimizing start up time."
                },
                new Session
                {
                    Title = "Azure AI & Machine Learning for Developers",
                    Id = "a446e00c-adea-46bc-8ac6-26d53aa9bc73",
                    SpeakerIds = new List<string> {"e72da88e-f9c5-48e1-b774-c4e7e0b51a76"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", },
                    Topic = new List<string> {"Smarter Apps"},
                    StartTime = new DateTime(2019, 10, 23, 14, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 15, 20, 0),
                    Room = "Beta",
                    Description = "As a developer, you’re probably thinking AI is something that only data scientists work on, and unless you want to go back and get a PhD in statistics, it’s not for you. I’m happy to prove you wrong. If you are a developer building real-world solutions you are already 2/3rds of the way towards leveraging the tremendous improvements in machine learning and artificial intelligence that have occurred in recent years. In this pragmatic session, we look at how you, the developer, can leverage Azure Machine Learning (including the new Visual ML and Augmented ML) and the Cognitive Services into your overall Azure solution architectures. Machine Learning usually does not stand by itself in the solution…whether you are using as Azure ML as the foundation for a data mining effort, using it as web service to inform automated processes or simply employing ML directly to realize new, untapped values in your data, Azure ML sits as an important and integrated component of your solution architecture. New services such as those provided with Microsoft Cognitive Services speed your development time by providing you with sophisticated, fully trained models for performing speech, text, vision and recommendation functions with the ease of integrating a REST API can yield richer and deeper interactive user experiences than was possible without having a specialized team with huge development budgets. Learn to bring intelligence to your solutions by attending this session!"
                },
                new Session
                {
                    Title = "The React Developer's Tool Belt",
                    Id = "b7c91d02-e9d4-4f9b-96e9-a1777841d5d8",
                    SpeakerIds = new List<string> {"7ad86657-7ffc-459d-8d87-529e996835f6"},
                    SessionType = "Session",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Smarter Apps", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 23, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 23, 16, 30, 0),
                    Room = "Panorama",
                    Description = "Details not yet available."
                },
                new Session
                {
                    Title = "The In-Vehicle Infotainment System - A Modern Usability Nightmare",
                    Id = "3ec11773-e1af-4945-b7f8-efe3329098c5",
                    SpeakerIds = new List<string> {"182a26cb-0e98-4c09-b699-74b8a957e044"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Design/UX"},
                    StartTime = new DateTime(2019, 10, 23, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 23, 16, 30, 0),
                    Room = "Panorama",
                    Description = "Cars are getting techier and fancier with each model update. Sometimes upgrades are great; some times not so great; and there are times, when upgrades are at the expense of the user. In fact, it's quite easy to get frustrated in a new vehicle. Join me as I muse over vehicle interiors and vehicle systems to examine the good, the somewhat bad and utterly ugly. The observations and implications go beyond vehicles. Lessons learnt apply to UX decisions in making any type of interface - software or hardware, in the world of connected and smart everything."
                },
                new Session
                {
                    Title = "One Dev Powerhouse: Using Azure DevOps & Xamarin.Forms to Develop, Build & Distribute Apps",
                    Id = "687ed31a-68b5-489d-a25f-8e58bc2ed7ac",
                    SpeakerIds = new List<string> { "916c4b37-b0d7-4523-95ec-9177e854dc61" },
                    SessionType = "Session",
                    Technology = new List<string> { ".NET" },
                    Topic = new List<string> {"Processes", "Desktop", "Mobile"},
                    StartTime = new DateTime(2019, 10, 23, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 23, 16, 30, 0),
                    Room = "Gamma",
                    Description = "In a single code commit, one developer can perform the duties of an entire team. You can build, test and release software to NuGet, Google Play, Apple App Store, Microsoft Store and much more using Azure DevOps. In this session, we will walk through a real-world scenario of a Xamarin.Forms application hosted on GitHub that is built, packaged and distributed to all the Stores."
                },
                new Session
                {
                    Title = "5 Practical Advices To Gain Predictability In Agile Environment",
                    Id = "cf81df6d-4e07-4569-9196-08d9f016512d",
                    SpeakerIds = new List<string> {"7572d449-7c9c-4e35-8155-eb130d8034df"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Processes"},
                    StartTime = new DateTime(2019, 10, 23, 15, 40, 0),
                    EndTime = new DateTime(2019, 10, 23, 16, 30, 0),
                    Room = "Alpha",
                    Description = "One of the biggest challenges Agile teams encounter is the ability to plan forward, gain predictability and manage stakeholder expectations. This is essential part of all type of projects and many teams struggle to reach this. In this lecture I will share my experience from the teams I have coached at leading software development companies in Bulgaria - what are the most spread errors teams do, what are the traps, and how they can approach this problem."
                },
                new Session
                {
                    Title = "The Care & Feeding of Software Engineers",
                    Id = "cdba9028-2ce7-45ff-bc15-5976231dce3c",
                    SpeakerIds = new List<string> {"a995eb1b-7405-413c-967f-268f327fdfef"},
                    SessionType = "Session",
                    Technology = new List<string> { ".NET", "JavaScript" },
                    Topic = new List<string> {"Career skills"},
                    StartTime = new DateTime(2019, 10, 23, 17, 30, 0),
                    EndTime = new DateTime(2019, 10, 23, 18, 15, 0),
                    Room = "Keynote Hall",
                    Description = "After years of excellence as a developer who gets things done, you are rewarded with a leadership title and more responsibility. Only now you are expected to manage people and not just code. What motivated you to improve doesn't seem to always work on your team. So what do you do?\r\n\r\nWe will explore the art of managing talented people and learning what the human needs for guidance and support from their leader."
                },
                new Session
                {
                    Title = "Prizes & Closing",
                    Id = "aede7a28-6aca-49e6-a417-2a828acee88c",
                    Technology = new List<string>(),
                    Topic = new List<string>(),
                    StartTime = new DateTime(2019, 10, 23, 18, 20, 0),
                    EndTime = new DateTime(2019, 10, 23, 18, 40, 0),
                    Room = "Keynote Hall"
                },

                // THURSDAY

                new Session
                {
                    Title = "Building a Chatbot with Kinvey Chat",
                    Id = "c3be49ea-e43c-4565-9288-0aab6eca99c0",
                    SpeakerIds = new List<string> {"c4d1bddd-e096-4a7d-a7a1-9773a86d6c55"},
                    SessionType = "Workshop",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Smarter Apps", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 24, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 24, 16, 0, 0),
                    Room = "Balkan Shipka + Balkan Kom | 6th Floor",
                    Description = "Chatbots introduce a whole new way for users to interact with your websites. A good chatbot can save your users from long and complicated forms, cut down on support requests, and make your services more approachable.\r\n\r\nIf you've ever wondered how to build a chatbot, then this workshop is for you. You will:\r\n\r\nDive into the core concepts of what makes a chatbot.\r\nLearn how to employ Machine Learning and Natural Language Processing to create a conversation flow that feels 100% natural.\r\nLook at a variety of possible conversations and challenges that go with them. \r\nBut more importantly, you will learn how to build a fully functioning chatbot in just a few hours, and all without a single IF statement."
                },
                new Session
                {
                    Title = "From Web to Mobile with NativeScript & Angular",
                    Id = "f9c9e151-a923-4677-9774-7ad7f12aa739",
                    SpeakerIds = new List<string> {"95f608f7-650d-412b-96a3-d675bdf114b6"},
                    SessionType = "Workshop",
                    Technology = new List<string> { "JavaScript" },
                    Topic = new List<string> {"Mobile", "Web", "Tools/Frameworks"},
                    StartTime = new DateTime(2019, 10, 24, 9, 0, 0),
                    EndTime = new DateTime(2019, 10, 24, 16, 0, 0),
                    Room = "Balkan Buzludzha + Balkan Botev | 6th Floor",
                    Description = "NativeScript opens up a whole new world for the Angular developers - a world where you can use your web skills to build mobile applications that run both on Android and iOS. But we can go even further - wouldn't it be nice if you could extend your existing web application with a shiny mobile app? It is true - Angular's platform agnostic nature allows you to reuse your business logic across multiple platforms. Come and see it for yourself! Together we'll transform an Angular website to a multi-platform application running on web, Android and iOS."
                }
            };

            return sessions;
        }
    }
}
