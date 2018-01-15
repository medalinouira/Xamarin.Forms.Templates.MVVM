/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System.Collections.Generic;

namespace Xamarin.Forms.Templates.MVVM.Models
{
    public class SampleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<string> Items { get; set; }
    }
}
