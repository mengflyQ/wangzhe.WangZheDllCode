using System;

namespace CSProtocol
{
	public enum COM_MAILOPTRESULT_TYPE
	{
		COM_MAILOPTRESULT_SENDSUCCESS = 1,
		COM_MAILOPTRESULT_SENDFAIL,
		COM_MAILOPTRESULT_NEWMAIL,
		COM_MAILOPTRESULT_PACKAGEFULL,
		COM_MAILOPTRESULT_PACKAGECLEAN,
		COM_MAILOPTRESULT_LISTGETING,
		COM_MAILOPTRESULT_SAMEVERSION,
		COM_MAILOPTRESULT_GETHEARTLIMIT,
		COM_MAILOPTRESULT_MAILTITLE,
		COM_MAILOPTRESULT_MAILCONTENT,
		COM_MAILOPTRESULT_ALLGETED
	}
}