using Bridal_salon;
using Bridal_salon.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class Tests
    {
        [Fact]
        public void Get_ReturnsOk()
        {
           var controller = new BrideController();
           var result = controller.Get();

           Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetId_ReturnsOk()
        {
            var id = "064971708";

            var controller = new BrideController();
            var result = controller.GetBrideById(id);

            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetId_ReturnsNotFound()
        {
            var id = "3245678457";

            var controller = new BrideController();
            var result = controller.GetBrideById(id);

            Assert.IsType<NotFoundResult>(result);
        }
        [Fact]
        public void Post_ReturnsOk()
        {
            var item = new Bride()
            {
                Id = "325747822",
                Address = "rhavad",
                Email = "b0876345689@gmail.com",
                Fullname = "Brachi " +
                                     "Shreiber",
                Height = 165,
                Phone1 = "054134568",
                Phone2 = "0527145678"
            };
            var controller = new BrideController();
            var result = controller.Post(item);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Post_ReturnsBadRequest()
        {
            var item = new Bride()
            {
                Id = "123456",
                Address = "rhavad",
                Email = "abgmail.com",
                Fullname = "Brachi " +
                                     "Shreiber",
                Height = 165,
                Phone1 = "054134568",
                Phone2 = "0527145678"
            };
            var controller = new BrideController();
            var result = controller.Post(item);
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public void Put_ReturnsOk()
        {
            var item = new Bride()
            {
                Id = "064971708",
                Address = "wghjk",
                Email = "ab@gmail.com",
                Fullname = "Brachi " +
                                     "Shreiber",
                Height = 165,
                Phone1 = "0563689433",
                Phone2 = "0527145678"
            };
            var controller = new BrideController();
            var result = controller.Put(item.Id,item);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Put_ReturnsNotFound()
        {
            var item = new Bride()
            {
                Id = "043445782",
                Address = "rhavad",
                Email = "ab@gmail.com",
                Fullname = "Brachi " +
                                     "Shreiber",
                Height = 165,
                Phone1 = "054134568",
                Phone2 = "0527145678"
            };
            var controller = new BrideController();
            var result = controller.Put(item.Id,item);
            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        public void Put_ReturnsBadRequest()
        {
            var item = new Bride()
            {
                Id = "12345678",
                Address = "rhavad",
                Email = "ab@gmail.com",
                Fullname = "Brachi " +
                                     "Shreiber",
                Height = 165,
                Phone1 = "054134568",
                Phone2 = "0527145678"
            };
            var controller = new BrideController();
            var result = controller.Put(item.Id,item);
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public void Delete_ReturnsOk()
        {
            var item = "064971708";
           
            var controller = new BrideController();
            var result = controller.Delete(item);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Delete_ReturnsNotFound()
        {
            var item = "043445782";

            var controller = new BrideController();
            var result = controller.Delete(item);
            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        public void GetByHeight_ReturnsOk()
        {
            var begHeigth = 150;
            var endHeigth = 180;
            var controller = new BrideController();
            var result = controller.GetByHeight(begHeigth, endHeigth);
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
