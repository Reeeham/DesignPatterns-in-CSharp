using System;
using System.Collections.Generic;
using System.Text;

namespace FrontControllerPatternDemo
{
    public class Dispatcher
    {
        private StudentView StudentView;
        private HomeView HomeView;

        public Dispatcher()
        {
            StudentView = new StudentView();
            HomeView = new HomeView();
        }

        public void Dispatch(string request)
        {
            if (request.Equals("STUDENT",StringComparison.OrdinalIgnoreCase))
            {
                 StudentView.Show();
            }
            else
            {
                HomeView.Show();
            }
        }
    }
}
