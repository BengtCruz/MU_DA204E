using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class ParticipantManager
    {
        #region FIELDS
        /* Fields */

        private List<Participant> participants;
        #endregion

        #region CONSTRUCTORS
        /* Constructors */
        public ParticipantManager()
        {
            participants = new List<Participant>();
        }
        #endregion

        #region PROPERTIES
        /* Properties */

        public int Count => participants.Count;
        #endregion

        #region METHODS
        /* Methods */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] GetParticipantsInfo()
        {
            string[] temp = new string[participants.Count];

            for(int i = 0; i < participants.Count; i++)
                temp[i] = participants[i].ToString();

            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="addrss"></param>
        /// <returns></returns>
        public bool AddParticipant(string fName, string lName, Address addrss)
        {
            Participant tempParticipant = new Participant();
            if (!tempParticipant.Validate())
                return false;
            
            participants.Add(tempParticipant);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        public bool AddParticipant(Participant participant)
        {
            if (participant == null)
                return false;

            participants.Add(participant);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Participant? GetParticipantAt(int i) => !CheckIndex(i) ? null : participants[i];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool DeleteParticipantAt(int i)
        {
            if(!CheckIndex(i))
                return false;

            participants.RemoveAt(i);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="participant"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool ChangeParticipantAt(Participant participant, int i)
        {
            if (participant == null || !CheckIndex(i))
                return false;
            else
            {
                participants[i] = participant;
                return true;
            }
        }

        #endregion

        #region AUX METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool CheckIndex(int i) => i >= 0 && i < participants.Count;

        #endregion
    }
}
