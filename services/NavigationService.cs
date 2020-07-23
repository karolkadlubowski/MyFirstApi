using System;
using System.Windows.Forms;

namespace StudentManager.Services
{
    public interface INavigationService
    {
        void Navigate<TFrom, TTo>(TFrom fromForm, Type toFormType, bool hideCurrent = false) where TFrom : Form where TTo : Form; // dac true
    }

    public class NavigationService : INavigationService
    {
        public void Navigate<TFrom, TTo>(TFrom fromForm, Type toFormType, bool hideCurrent = false) where TFrom : Form where TTo : Form
        {
            if (hideCurrent)
                fromForm.Hide();

            TTo toForm = (TTo)Activator.CreateInstance(toFormType);
            toForm.ShowDialog();

            if (hideCurrent)
                fromForm.Close();
        }
    }
}
