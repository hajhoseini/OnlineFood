using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Application.Services.Users.Commands;

namespace OnlineFood.WebHost.Controllers;

public class Users:Controller
{
 private readonly IUserCommandService _userCommandService;

 public Users(IUserCommandService UserCommandService)
 {
  _userCommandService = UserCommandService;
 }
 [HttpGet]
 public async Task<IActionResult>Index()
 {

  return View();
 
 }
 [HttpPost]
 public async Task<IActionResult>Index(LoginDto login)
 {
  var result=await _userCommandService.Login(login);
  if (result==true)
  {
   return RedirectToAction("Index","Home");
  }

  return View(ViewBag.error="خطا در لاگین");
 
 }
 [HttpGet]
 public async Task<IActionResult> reg()
 {
  return View(); 
 }
 [HttpPost]
 public async Task<IActionResult> reg(RegisterViewModel dto)
 {
 
 var result=await _userCommandService.Register(dto);
 if (result==true)
 {
  return RedirectToAction("Index","Home");
 }
 return View(ViewBag.error="خطا در لاگین ");
 }
 [HttpPost][ValidateAntiForgeryToken]
 
 public async Task<IActionResult> Logout( )
 {
  await _userCommandService.SignOutAsync();

 
  return RedirectToAction("Index", "Home");
 }
}