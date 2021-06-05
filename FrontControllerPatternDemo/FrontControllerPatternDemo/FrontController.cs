using System;
using System.Collections.Generic;
using System.Text;

namespace FrontControllerPatternDemo
{
    public class FrontController
    {
        private Dispatcher Dispatcher;

        public FrontController()
        {
            Dispatcher = new Dispatcher();
        }

        private bool IsAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }

        private void TrackRequest(string request)
        {
            Console.WriteLine("Page requested: " + request);
        }

        public void dispatchRequest(string request)
        {
            //log each request 
            TrackRequest(request);

            //authenticate the user
            if (IsAuthenticUser())
            {
                Dispatcher.Dispatch(request);
            }
        }


    }
}
