using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class DatabaseOptions
    {
#if DEBUG

        public const string DataBaseConectToString = @"Data Source=DESKTOP-AH919FB;Initial Catalog=PostMaker;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
#endif
#if RELEASE
public const string DataBaseConectToString = @"";
#endif
    }
}
