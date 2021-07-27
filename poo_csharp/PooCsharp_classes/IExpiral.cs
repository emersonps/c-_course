using System;
using System.Collections.Generic;
using System.Text;

namespace ComInterface
{
    public interface IExpiravel
    {
        TimeSpan GetTempoRestante();
    }
}