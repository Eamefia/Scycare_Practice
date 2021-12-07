using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScyLab
{
    public class AppState
    {
        public string SelectedColour { get; private set; }

        public event Action OnChange;

        public void SetColour(string colour)
        {
            SelectedColour = colour;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
