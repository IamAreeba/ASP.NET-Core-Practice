

//To automatically close the console when debugging stops, enable Tools -> Options -> Debugging -> Automatically close the 
//console when debugging stops.


// ====================================== 01 ====================================== //
/*
    ASP.NET core 6 is the latest version
    PlatForm = OS
    FW = A framework is a pre-built set of tools, libraries, and conventions that provides a foundation for building software 
    applications. It offers a structured way to develop and organize code, making it easier for developers to create applications 
    by providing reusable templates and components.

    Cross Platform = Software/Program which run on multiple OS
    Microsoft Make Windows based products but now they are moving towards crossPlatform, Cloud Based and open source
    So he invented new product : 'Microsoft .NET core'
    In 2000 MS launch 1st .NET Framework
    In 2016 MS launch ASP.NET Core which is crossPlatform, Cloud Based and open source
    Cloud Based System: We can deploy/Upload/Publish it on Internet Server
    Previously MS was closed source  now it is open Source 
    Windows We are using is a pirated version (Limited functionality)

    ASP.NET Core (ASP.NET 5) 2016:
    Its is based on MVC architecture
    It is a new Version of ASP.NET.
    Previously we were having .NET framework now we have .NET core framework
    It consists of modular(separate) components with minimal overhead (min work/efforst/cost)

    Previously we have 2 frameworks:
    1. ASP.NET (ASP.NET Core Web Form)
    2. ASP.NET MVC

    Latest version of ASP.NET Core is ASP.NET Core 7.0(24 Feb 2023)
    We will use ASP.NET Core 6 cuz it is LTS (Long Term Support)
    ASP.NET Core is different and .NET Core is different 
    ASP.NET Core is use for making web app and it depend on .NET core 6 which is our framwwork

    Web App FM                                     FrameWork
    ASP.NET Core 2 ---------- Based On ---------- .NET Core 2 (.NET 2)
    ASP.NET Core 3 ---------- Based On ---------- .NET Core 3 (.NET 3)
    ASP.NET Core 4 ---------- Based On ---------- .NET Core 4 (.NET 4)
    ASP.NET Core 5 ---------- Based On ---------- .NET Core 5 (.NET 5)
    ASP.NET Core 6 ---------- Based On ---------- .NET Core 6 (.NET 6)

    ASP.NET Core versions are increasing also .NET core framework are also increasing\
    After .NET Core 5 Core word is dropped 


*/


// ====================================== 02 ====================================== //
/*
    Q. Difference between .NET and .NET Core frame work ?

    FrameWork = Bunch of code that a programmer can call without having to write it explicitly
    .NET FW is a collection of libraries
    C#.NET: Cuz C# works with .NET
    Nowadays we cant see versions of .NET frame work

    DIFFERENCE
               .NET frame work                              .NET Core frame work
    1.    .NET FW is dependent on .NET              All the dependency of .NET are implemented inside the project
          FW installed on windows                   We dont need to install any thing to run that project
    2.    No Dependency Injenction                  Built-in Dependency Injenction
    3.    Full flagged FW                           Not Full Flagged. It is evolving version by version
    4.    Less Scalable                             High Scalable
    5.    No Built in support for dependency        Built in support for dependency
          Injection

    Scability: FW ko change karna Scale karna/extend karna
    For dependency Injenction we have to write the whole code from scratch to do that work 

*/

// ====================================== 03 ====================================== //
/*
    Q. Difference between ASP.NET and ASP.NET Core ?
    Modularity: Separation of concerns. The work which i need to do i will make separate file of it

*/

sss

// ====================================== 04 ====================================== //
/*
    Q. MVC with ASP.NET Core 6

    Every language has MVC concept
    School so business entity will be employees, teachers, students. To represent these entities we use model.
    Model(Business Entities): Model are basically classes. We do all work of DB through Model
    View(Presentation Logic): View are HTML pages. we do all work of UI here.
    Controller(Business Logic):
    Main logic of application is in Controller
    If Model and View wants to communicate so controller will help them to communicate. How to get data from model and
    pass in View so these works are done by controller
    Controller is a bridge btw Model and View and it is also called the backbone of application
    When we request the particular website that request also goes to controller

    The above all the work we are doing in separate module
    When we make the architecture/structure of our application we use the concept of MVC
    MVC is a design Pattern not a FW and not a programming Language
    ASP.NET Core is a FW and it has a technique a design pattern called MVC
    Design Pattern: Through design we make our application


    eg. Making architecture of MVC in Application:
    Empty Web App --> make floder of Model, View, Controller --> Model(DB Entities), View(UI), Controller(Business Logic)
    --> Model and View interaction

    We implement separation od concern in MVC Application
    isolation: We can divide app in pieces and make MVC. And many people work on this app cuz of isolation

    If we dont have model in app (cuz of static work we are doing) so controller directly display view
    MVC Work Flow. See the Diagram

*/


// ====================================== 05 ====================================== //
/*
    In Empty folder we have to make every thing from scratch like Model, Vie and Controller folder
    STARTUP.asx and Global.asax are not supported in .NET core rather we have appsetting file
    By Default Index() is called in Controller -> HomeController

*/

// ====================================== 06 ====================================== //
/*
    Question: Interview question of launch setting.json
    WorkFlow: Which file run first
    All requirements for running the appication like port and server etc are handled in LauncgSetting.json
    Cuz to run the app we need host and port no 
    launch setting.json will be useless if we deploy our app in internet server

    wwroot: contain static files. Files which will not change will be in this files
            eg. Want to display images. Bootstrap FW. 
    If we want to use Botstrap, Jquery we get by default support in it if we make the project of MVC. 
    But we will not get the above files in Empty tempelate we have to make it on our own
    1st time when u run the app so HomeController Index method will run cuz it is define by default on routing

    Comments in Program.cs
    1st request will go in Program.cs. Means it follow the pipeline of program.cs


*/


// ====================================== 07 ====================================== //
/*
    We have custome built-in middlewares in program.cs
    Middlewares are just func() . When we request from browser middleWares run.
    The logic inside middleware ece only we user request something cuz it passes from that middlewares

    So requests are handled by middlewares 
    e.g. They handle the user authorization. Means i want to give access to authorize user so we can take help of middleware
    Means a work which i want to run in every request
    In every request all middlewares will run cuz they all are declared in Request pipelines

    Run Method never run next middlewares means subsequent middlewares 
    Program.cs is our request pipeline and all the middlewares are registered here so if i go to home, login page 
    all middlewares will run. Cuz they all are dec in request(get, post etc) pipeline
    Application pipeline: program.cs
    To define custom middlewares we use Run KW. 
    We have context param. To handle http request we have made this KW. It is derived from Http Context
    order f middleware is very important
    Run method never exe next/subsequent middlewares. Cuz they dont have the concept of next
    Use:
    If u want in your pipeline to run multiple middlewares so use "Use" func. Inside this we get facility to run
    next middlewares
    next : Request Delegate. It will run the next middlewares 
    how by using the context KW cuz it contain request


*/


