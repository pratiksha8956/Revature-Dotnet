using System;

namespace DelegatesDemo
{
    // Custom EventArgs
    public class OnClickEventArgs : EventArgs
    {
        public string ButtonName { get; set; }
    }

    // Publisher
    public class Button
    {
        // Step 1: Delegate
        public delegate void OnClickHandler(object sender, OnClickEventArgs e);

        // Step 2: Event
        public event OnClickHandler OnClick;

        // Step 3: Raise event
        public void Click()
        {
            Console.WriteLine("Button clicked");

            OnClick?.Invoke(
                this,
                new OnClickEventArgs { ButtonName = "Submit" }
            );
        }
    }

    // Subscriber
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();

            // Subscribe to event
            button.OnClick += Button_OnClick;

            // Trigger event
            button.Click();
        }

        // Event handler
        static void Button_OnClick(object sender, OnClickEventArgs e)
        {
            Console.WriteLine($"Event received from button: {e.ButtonName}");
        }
    }
}
