using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace sohi_russian
{
    [TestFixture]
    class ntest
    {
        [TestCase]
        public void score_test()
        {
            spinner test = new spinner();
            Assert.AreEqual(1, test.spin_bullete(6));
        }


        [TestCase]
        public void score_test_neg()
        {
            spinner test_neg = new spinner();
            Assert.AreNotEqual(2, test_neg.spin_bullete(6));

        }
    }
}

