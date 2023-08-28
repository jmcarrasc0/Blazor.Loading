using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jmcarrasc0.Blazor.Loading
{
    public class LoadingServices
    {
            public event Action OnShow;
            public event Action OnHide;

            public void Show()
            {
                OnShow?.Invoke();
            }

            public void Hide()
            {
                OnHide?.Invoke();
            }
       
    }
}
