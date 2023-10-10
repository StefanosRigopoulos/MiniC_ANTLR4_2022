using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniC
{
    public enum VariableType
    {
        VT_NA, VT_STATEMENT, VT_EXPRESSION,
        VT_INTEGER,
        VT_DOUBLE,
        VT_STRING,
        VT_COMMENT,
        VT_VARIABLE
    }

    public abstract class CVariableType
    {
        private VariableType m_variableType;
        public VariableType VariableType => m_variableType;

        protected CVariableType(VariableType variableType) // Constructor
        {
            m_variableType = variableType;
        }
    }
}
