








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class MakeArray : ReqlQuery {
    
    
        public MakeArray (object arg) : this(new Arguments(arg), null) {
        }
        public MakeArray (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public MakeArray (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.MAKE_ARRAY, args, optargs) {
        }

    protected MakeArray (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static MakeArray FromArgs(params object[] args){
         return new MakeArray (new Arguments(args), null);
        }


    

    


    
    }
}
