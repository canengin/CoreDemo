using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commnentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Can"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Berna"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Yusuf"
                }
            };
            return View(commnentValues);
        }
    }
}
