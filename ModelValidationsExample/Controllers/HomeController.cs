﻿using Microsoft.AspNetCore.Mvc;
using CollectionBindingModelValidationsCoreMVC6.Models;
using CollectionBindingModelValidationsCoreMVC6.CustomModelBinders;

namespace CollectionBindingModelValidationsCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("register")]
    //Example JSON: { "PersonName": "William", "Email": "william@example.com", "Phone": "123456", "Password": "william123", "ConfirmPassword": "william123" }
    //[ModelBinder(BinderType = typeof(PersonModelBinder))]
    public IActionResult Index(Person person)
    {
      if (!ModelState.IsValid)
      {
        //get error messages from model state
        string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage));
  
        return BadRequest(errors);
      }

      return Content($"{person}");
    }
  }
}
