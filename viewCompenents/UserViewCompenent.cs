using Celilcavus.Model;
using Microsoft.AspNetCore.Mvc;

namespace Celilcavus.viewCompenets;
public class UserViewCompenent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        List<User> user = new();

        for (int i = 1; i < 100 + 1; i++)
        {
            User user1 = new User();
            user1.Number = i;
            user1.Name = FakeData.NameData.GetFirstName();
            user1.LastName = FakeData.NameData.GetSurname();
            user.Add(user1);
        }
        return View(user);
    }
}