








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Update : ReqlQuery {
    
    
        public Update (object arg) : this(new Arguments(arg), null) {
        }
        public Update (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Update (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.UPDATE, args, optargs) {
        }

    protected Update (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Update FromArgs(params object[] args){
         return new Update (new Arguments(args), null);
        }


    

    


    
    }
}
