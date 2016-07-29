using System;
using FabricSdk;
using DigitsKit;
using UIKit;

namespace Xamarin.iOS_Digits_Sample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

       

        private void something(IDigitsSession arg1, ErrorCode arg2)
        {
            var res = arg1.PhoneNumber;
        }

        partial void UIButton12_TouchUpInside(UIButton sender)
        {
            var digits = Digits.Instance;
            digits.Authenticate(something);
        }
    }
}