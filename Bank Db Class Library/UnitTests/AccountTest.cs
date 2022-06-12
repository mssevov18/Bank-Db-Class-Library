using Bank_Db_Class_Library;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public partial class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("emailemail.bg", true)]
        [TestCase("em@ail@gmail.bg", true)] // Only 1 @ should be allowed outside of quotation marks. But I can't implement it, yet
        [TestCase("i_like_underscore@but_its_not_allowed_in_this_part.example.com", true)] // Underscore is not allowed in domain part
        [TestCase("QA[icon]CHOCOLATE[icon]@test.com", true)] // icon characters
        [TestCase("example@-mail.com", true)] // Hyphens can't be at the start of the domain part
        [TestCase("example@mail.com-", true)] // Hyphens can't be at the end of the domain part
        //[TestCase("", true)]
        [TestCase("email@email.bg", false)]
        [TestCase("outlook.official.idk@microsoft.noreply.bg", false)]
        [TestCase("\" \"@example.org", false)]
        //[TestCase("\"very.(),:;<>[]\".VERY.\"very@\\ \"very\".unusual\"@strange.example.com", false)]
        //[TestCase("postmaster@[123.123.123.123]", false)]
        //[TestCase("postmaster@[IPv6:2001:0db8:85a3:0000:0000:8a2e:0370:7334]", false)]
        //[TestCase("", false)]
        //[TestCase("", false)]
        public void TestEmailSyntax(string email, bool throwException)
        {
            Account account = new Account();
            try
            {
                account.Email = email;
            }
            catch (FormatException e)
            {
                if (throwException)
                    Assert.Pass();
            }
            if (throwException)
                Assert.Fail();
            else
                Assert.Pass();
        }
    }
}