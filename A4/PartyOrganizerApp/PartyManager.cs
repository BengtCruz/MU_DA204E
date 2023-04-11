using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizerApp
{
    internal class PartyManager
    {
        /// <summary>
        /// Cost per person attending the event. With get, set properties instance definitions.
        /// </summary>
        private double costPerPerson;
        /// <summary>
        /// Fee per person attending the event. With get, set properties instance definition.
        /// </summary>
        private double feePerPerson; 
        /// <summary>
        /// Guest list array.
        /// </summary>
        private string[] guestList;

        /// <summary>
        /// Constructor for PartyManager class, which expects
        /// maxNumberGuests from Form1's input.
        /// </summary>
        /// <param name="maxNumberGuests"> Max number of guests taken from Form1 </param>
        public PartyManager(int maxNumberGuests)
        {
            // Create guest array in the constructor
            guestList = new string[maxNumberGuests]; 
        }

        /// <summary>
        /// Cost per person property to get and set input cost value.
        /// </summary>
        public double CostPerPerson
        {
            get => costPerPerson;
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        /// <summary>
        /// Fee per person property to get and set input fee value.
        /// </summary>
        public double FeePerPerson
        {
            get => feePerPerson;
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        public int Count
        {
            get => totalNumGuests();
        }
        /// <summary>
        /// Current total number of guests in the list.
        /// </summary>
        /// <returns> Number of guests in list </returns>
        private int totalNumGuests()
        {
            int count = 0;

            for (int i = 0; i < guestList.Length; i++)
                if (!string.IsNullOrEmpty(guestList[i]))
                    count++;

            return count;
        }

        /// <summary>
        /// Find the first vacant position from start to end.
        /// </summary>
        /// <returns> Index of vacant slot in list. Return -1 if there is no vacant slot. </returns>
        private int FindVacantSlot()
        {
            int vacantSlot = -1;
            for(int i = 0; i < guestList.Length; i++)
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    vacantSlot = i;
                    break;
                }

            return vacantSlot;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="secondName"></param>
        /// <returns></returns>
        public bool AddNewGuest(string firstName, string secondName)
        {
            bool ok = true;
            int vacantSlot = FindVacantSlot();

            if (vacantSlot != -1)
                guestList[vacantSlot] = FullName(firstName, secondName);
            else
                ok = false;

            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] GetGuestList() => guestList;

        /// <summary>
        /// 
        /// </summary>
        public double TotalCost => costPerPerson*totalNumGuests();

        /// <summary>
        /// 
        /// </summary>
        public double TotalFees => feePerPerson*totalNumGuests();

        /// <summary>
        /// 
        /// </summary>
        public double TotalEarned => (feePerPerson - costPerPerson) * totalNumGuests();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="secondName"></param>
        /// <returns></returns>
        private string FullName(string firstName, string secondName) => secondName + ", " + firstName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            guestList[index] = string.Empty;
            MoveElementsOneStep(index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void MoveElementsOneStep(int index)
        {
            for(int i = index+1; i < guestList.Length; i++)
            {
                guestList[i-1] = guestList[i]; // move 1 to left
                guestList[i] = string.Empty;
            }
        }
    }
}
