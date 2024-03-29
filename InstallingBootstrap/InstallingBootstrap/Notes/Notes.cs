

// ======================== 24 ============================
/*
 * cdn: Content Delivery Network
 * When we add any client side library it also adds a file in our project called libman.json(LibraryManager.json) which contain all the configuration of our wwwroot folder
 * 
 * Master File is connected to all our Views
 * Adding Master page: _Layout.cshtml
 * I will add all my static files/ ClientSide Lib here and then i will connect it with all of my views 
 * 
 * When we adding the files we have wwwroot in our Link we dont have to addd it cuz it is public by default 
 * But if you are using Bootstrap in your Views it will not render cuz u have to add a method called 
 * app.UseStaticFiles() in program.cs
 *  
 *  
 */