

// =========================== 28 =============================
/*
 *  TagHelper: Increase the functionality of Images.
 *             When Image path  is change download the image from server
 *             
 *  If using empty tempelate use app.UseStaticFiles() middleware in program.cs
 *  TagHelper use for Image is asp-append-version="true". It checks if the path is same it take Image from cache if not it 
 *  download image from server
 *  If Image path is same retrive it from cache 
 *  If image path is change download it from server
 *  If u disable cache then every time browser renders image willbe downloaded from server
 *  
 */