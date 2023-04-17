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

        int Count => participants.Count;
        #endregion

        #region METHODS
        /* Methods */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string[] GetParticipantInfo()
        {
            string[]temp = new string[participants.Count];

            for(int i = 0; i < participants.Count; i++)
                temp[i] = participants[i].ToString();

            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool CheckIndex(int i) => i >= 0 && i < participants.Count;

        #endregion
    }
}
