﻿using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.DtoLayer.Dtos.CustomerAccountProcessDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;
        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            
            var ReceiverAccountNumberID = context.CustomerAccounts.Where(x => x.CustomerAccountNumber ==
            sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber).Select(y => y.CustomerAccountID).FirstOrDefault();

            sendMoneyForCustomerAccountProcessDto.SenderID = user.Id;//Gönderici Id si aldım.//
            sendMoneyForCustomerAccountProcessDto.ProcessDate =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            sendMoneyForCustomerAccountProcessDto.ProcessType = "remittance(Havale)";

            sendMoneyForCustomerAccountProcessDto.ReceiverID = ReceiverAccountNumberID;

           // _customerAccountProcessService.TInsert()

            
            return RedirectToAction("Index","Deneme");
        }
    }
}
