﻿using CalendarSkill.Models.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarSkill.Models
{
    public enum AskParameterType
    {
        /// <summary>
        /// defaut type, ask for details about event
        /// </summary>
        AskForDetail = 0,

        /// <summary>
        /// ask for start time
        /// </summary>
        AskForStartTime = 1,

        /// <summary>
        /// ask for end time
        /// </summary>
        AskForEndTime = 2,

        /// <summary>
        /// ask for start and end time
        /// </summary>
        AskForTime = 3,

        /// <summary>
        /// ask for duration
        /// </summary>http://tianqi.sogou.com/beijing/
        AskForDuration = 4,

        /// <summary>
        /// ask for location
        /// </summary>
        AskForLocation = 5,

        /// <summary>
        /// ask for attenddees
        /// </summary>
        AskForAttendee = 6,

        /// <summary>
        /// ask for title
        /// </summary>
        AskForTitle = 7,

        /// <summary>
        /// ask for content
        /// </summary>
        AskForContent = 8,
    }

    public class AskParameterModel
    {
        public bool NeedDetail { get; set; } = false;

        public bool NeedTime { get; set; } = false;

        public bool NeedDuration { get; set; } = false;

        public bool NeedLocation { get; set; } = false;

        public AskParameterModel(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                return;
            }

            content = content.ToLower();
            List<AskParameterType> askParameterTypes = AskParameterTemplate.GetAskParameterTypes(content);
            foreach (AskParameterType type in askParameterTypes)
            {
                switch (type)
                {
                    case AskParameterType.AskForDetail:
                        {
                            //can set defuat here
                            break;
                        }

                    case AskParameterType.AskForStartTime:
                        {
                            NeedTime = true;
                            NeedDetail = true;
                            break;
                        }

                    case AskParameterType.AskForEndTime:
                        {
                            NeedTime = true;
                            NeedDetail = true;
                            break;
                        }

                    case AskParameterType.AskForTime:
                        {
                            NeedTime = true;
                            NeedDetail = true;
                            break;
                        }

                    case AskParameterType.AskForDuration:
                        {
                            NeedDuration = true;
                            NeedDetail = true;
                            break;
                        }

                    case AskParameterType.AskForLocation:
                        {
                            NeedLocation = true;
                            NeedDetail = true;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}