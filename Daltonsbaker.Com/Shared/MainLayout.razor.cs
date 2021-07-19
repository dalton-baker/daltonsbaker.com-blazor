using MudBlazor;
using System;
using System.Diagnostics;

namespace Daltonsbaker.Com.Shared
{
    public partial class MainLayout
    {
        private string _arrowColor = "#594ae2";
        private int _selectedIndex = -1;
        private MudCarousel<object> _mudCarousel;

        private int SelectedIndex {
            get => _selectedIndex;
            set {
                Debug.WriteLine("IndexChanged " + value);
                _selectedIndex = value;
            }
        }

        private void OnSwipe(SwipeDirection direction)
        {
            switch(direction)
            {
                case SwipeDirection.LeftToRight:
                    _mudCarousel.Next();
                    break;
                case SwipeDirection.RightToLeft:
                    _mudCarousel.Previous();
                    break;
            }

            StateHasChanged();
        }

        private void SelectedIndexChanged(int index)
        {
            Console.WriteLine("IndexChanged");

            _arrowColor = index switch
            {
                3 => "#000000",
                _ => "#FFFFFF",
            };
            StateHasChanged();
        }
    }
}
