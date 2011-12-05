using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using deliveryweb.config;

namespace deliveryweb.utils
{
    class Utils
    {

        /// <summary>
        /// funcion para capturar los log de las excepciones que se disparan en la aplicacion
        /// </summary>
        /// <param name="exc">exception</param>
        public static void logExceptionError(Exception exc){
            string sSource;
            string sLog;
            string sEvent;

            sSource = Config.nameProgram;
            sLog = exc.Message;
            sEvent = exc.Source;
            //sMessageBox.Show("source: " + exc.Source + "\nmessage: " + exc.Message + "\n");

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent);
            EventLog.WriteEntry(sSource, sEvent,
                EventLogEntryType.Warning, 234);
        }
    }
}
