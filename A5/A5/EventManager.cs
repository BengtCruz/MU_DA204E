using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class EventManager
    {
        #region FIELDS

        private string title;
        private double costPerPerson;
        private double feePerPerson;
        private ParticipantManager participantManager;

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="costPerperson"></param>
        /// <param name="feePerperson"></param>
        public EventManager()
        {
            participantManager = new ParticipantManager();
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// 
        /// </summary>
        public string Title { get { return title; } set { if (!string.IsNullOrEmpty(value)) title = value; } }

        /// <summary>
        /// 
        /// </summary>
        public double CostPerPerson { get { return costPerPerson; } set { costPerPerson = value; } }

        /// <summary>
        /// 
        /// </summary>
        public double FeePerPerson { get { return feePerPerson; } set { feePerPerson = value; } }

        /// <summary>
        /// 
        /// </summary>
        public ParticipantManager ParticipantMnger => participantManager;

        #endregion

        #region METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalcTotalCost() => (costPerPerson * participantManager.Count) * 100 / 100;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalcTotalFee() => (feePerPerson * participantManager.Count) * 100 / 100;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalcTotalIncome() => (CalcTotalFee() - CalcTotalCost()) * 100 / 100;

        #endregion
    }
}
