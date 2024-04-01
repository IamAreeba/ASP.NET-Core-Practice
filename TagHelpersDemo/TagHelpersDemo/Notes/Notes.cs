
// ========================== 26 ============================
/*
 *  Creating HyperLinks using Tag Helpers
 * 
 *  In MVC 5: HTML Helpers : They are methods 
 *  In .NET: Tag Helpers : To render HTML on server side: They are attributes
 *  When we use HTML Helpers it renders the HTML on the server side cuz .NET Core works on the server side
 *  
 *  Diff btw @HTML.ActionLink and @Url.Action ? 
 *  @HTML.ActionLink generate the whole anchor | @Url.Action generates the href not the whole a
 *  
 *  When we click on any Link an Id is generated and that Id will take us to View 
 *  We usually do the Id work with Edit or Delete
 *  
 * 
 */



// ========================== 27 ============================
/*  
 *  If we want the Organization name in our Convention based Routing we can just simply write that.
 *  But then our Index method wont run cuz convention is changed. So we have to use Attribute Routing on that
 *  But the changes which we have applied will not be update on Simple HTML Tag but will be updated on the HTML Tag helper
 * Also HTML Helper tags are also updated only simple HTML Tag is not updated
 * 
 * But use only Tag Helper cuz it belongs to .NET Core Framework
 * 
 */