﻿

// ==================================  12 =================================
/*
 * ASP.NET Core is based on MVC
 * Controller is backbone of MVC
 * Model and view cant directly communicate only controller can make communication btw them so it works as a police
 * To check the URL which is entered by user is checked by Routing which sees weather this URL is valid or not if valid then he passes to controller
 * Controller is a CSharp class which has action methods
 * 
 */




// ==================================  13 =================================
/*
 * Action method can return data, view, partial view, json etc
 * So Action method can return alot of DT and normal DT(String, bool etc)
 * IActionResult. this I is representing interface
 * ActionResult is a abstract class in MVC5
 * IActionResult ka interface ko bohot sari e.g. View Result, PartialViewResult, JsonResult etc classes ne implement kiya hova he
 * So this IActionResult can return diff type of data. By default it is view
 * 
 * If return type is ViewResult then it can only return view but if return type is IActionResult then it can return everything
 * 
 * req which comes to controller is handeled, res and received by Action Method
 * IActionResult is general
 * View Result, PartialViewResult, JsonResult are child and IActionResult and ActionResult are parent
 * PartialView means view inside view.
 * PartialView is also called InnerView or Nested View. Ye kisi view ke ander render kiya jata he
 * If we have to pass data from application to server then we wrap that data in form of JSON
 * 
 */

