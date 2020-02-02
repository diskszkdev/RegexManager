using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexManager;
using System;

namespace RegexManagerTest
{
    [TestClass]
    public class RegexUtilTest
    {
        private RegexUtil _regexUtil;


        [TestInitialize]
        public void Initialize()
        {
            _regexUtil = new RegexUtil();
        }

        [TestMethod]
        public void HalfNumber_OK()
        {
            var data = "0123456789";
            var result = _regexUtil.IsHalfNumber(data);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HalfNumber_NG()
        {
            var data = "0123456789m";
            var result = _regexUtil.IsHalfNumber(data);
            Assert.IsFalse(result);

            data = "";
            result = _regexUtil.IsHalfNumber(data);
            Assert.IsFalse(result);

            Assert.ThrowsException<ArgumentNullException>(() => _regexUtil.IsHalfNumber(null));
        }

        [TestMethod]
        public void HalfAlphabet_OK()
        {
            var data = "abcdefghijklmnopqrstuvwxyz";
            var result = _regexUtil.IsHalfAlphabet(data);
            Assert.IsTrue(result);

            data = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            result = _regexUtil.IsHalfAlphabet(data);
            Assert.IsTrue(result);

            data = "abcdefghijklMNOPQRSTUVWXYZ";
            result = _regexUtil.IsHalfAlphabet(data);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HalfAlphabet_NG()
        {
            var data = "abcdefghijklmnopqrstuvwxyz5";
            var result = _regexUtil.IsHalfAlphabet(data);
            Assert.IsFalse(result);

            data = "";
            result = _regexUtil.IsHalfAlphabet(data);
            Assert.IsFalse(result);

            Assert.ThrowsException<ArgumentNullException>(() => _regexUtil.IsHalfAlphabet(null));
        }
    }
}