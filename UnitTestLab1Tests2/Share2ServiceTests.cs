using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestLab1Tests2;
namespace UnitTestLab1.Tests
{
    [TestClass()]
    public class Share2ServiceTests
    {
        [TestMethod()]
        public void ValidateMemberTest_傳入帳號密碼_若無帳號_回傳NoAccount()
        {
            DBBRepositoryNoAccountStub DBBRepositoryNoAccountStub = new DBBRepositoryNoAccountStub();
            Share2Service share2Service = new Share2Service(DBBRepositoryNoAccountStub);
            var account = "adminErr";
            var password = "admin123";
            var expected = "No Account!";
            var actual = share2Service.ValidateMember(account, password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateMemberTest_傳入帳號密碼_若有帳號但密碼錯誤_回傳PasswordError()
        {
            DBBRepositoryStub DBBRepositoryStub = new DBBRepositoryStub();
            Share2Service share2Service = new Share2Service(DBBRepositoryStub);
            var account = "admin";
            var password = "adminErr";
            var expected = "Password Error!";
            var actual = share2Service.ValidateMember(account, password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateMemberTest_傳入帳號密碼_若有帳號且密碼正確_回傳Success()
        {
            DBBRepositoryStub DBBRepositoryStub = new DBBRepositoryStub();
            Share2Service share2Service = new Share2Service(DBBRepositoryStub);
            var account = "admin";
            var password = "admin123";
            var expected = "Success!";
            var actual = share2Service.ValidateMember(account, password);
            Assert.AreEqual(expected, actual);
        }


    }
}