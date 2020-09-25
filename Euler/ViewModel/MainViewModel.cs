using Euler.Helpers;
using Euler.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public List<EulerProblem> Problems { get; set; }

        private string log;
        public string Log
        {
            get => log;
            set 
            {
                Set<string>(ref log, value);
            }
        }

        private EulerProblem selected;
        public EulerProblem Selected
        {
            get => selected;
            set 
            {
                Set<EulerProblem>(ref selected, value);
            }
        }

        private RelayCommand _solveProblem;
        public RelayCommand SolveProblem
        {
            get
            {
                if (_solveProblem == null)
                {
                    _solveProblem = new RelayCommand(() => { Log = ""; Selected.SolveProblem(); });
                }
                return _solveProblem;
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            MessengerInstance.Register<string>(this, MessengerTokens.Log, (i) => Log += $"{i}{Environment.NewLine}");
            Problems = new List<EulerProblem>();
            Problems.Add(new Multiple3and5());
            Selected = Problems.First();
        }
    }
}