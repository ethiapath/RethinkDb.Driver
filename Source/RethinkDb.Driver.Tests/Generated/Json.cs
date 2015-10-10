




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class Json : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #1
                 /* ExpectedOriginal: [1, 2, 3] */
                 var expected = r.array(1, 2, 3);
                 
                 /* Original: r.json("[1,2,3]") */
                 var obtained = runOrCatch( r.json("[1,2,3]") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #2
                 /* ExpectedOriginal: 1 */
                 var expected = 1;
                 
                 /* Original: r.json("1") */
                 var obtained = runOrCatch( r.json("1") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #3
                 /* ExpectedOriginal: {} */
                 var expected = r.hashMap();
                 
                 /* Original: r.json("{}") */
                 var obtained = runOrCatch( r.json("{}") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #4
                 /* ExpectedOriginal: "foo" */
                 var expected = "foo";
                 
                 /* Original: r.json('"foo"') */
                 var obtained = runOrCatch( r.json("\"foo\"") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #5
                 /* ExpectedOriginal: err("ReqlQueryLogicError", 'Failed to parse "[1,2" as JSON:' + ' Missing a comma or \']\' after an array element.', [0]) */
                 var expected = err("ReqlQueryLogicError", "Failed to parse \"[1,2\" as JSON:" + " Missing a comma or ']' after an array element.", r.array(0));
                 
                 /* Original: r.json("[1,2") */
                 var obtained = runOrCatch( r.json("[1,2") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #6
                 /* ExpectedOriginal: ('[1,2,3]') */
                 var expected = "[1,2,3]";
                 
                 /* Original: r.json("[1,2,3]").to_json_string() */
                 var obtained = runOrCatch( r.json("[1,2,3]").toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #7
                 /* ExpectedOriginal: ('[1,2,3]') */
                 var expected = "[1,2,3]";
                 
                 /* Original: r.json("[1,2,3]").to_json() */
                 var obtained = runOrCatch( r.json("[1,2,3]").toJson() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #8
                 /* ExpectedOriginal: ('{"foo":4}') */
                 var expected = "{\"foo\":4}";
                 
                 /* Original: r.json("{\"foo\":4}").to_json_string() */
                 var obtained = runOrCatch( r.json("{\"foo\":4}").toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #9
                 /* ExpectedOriginal: ('{"foo":4}') */
                 var expected = "{\"foo\":4}";
                 
                 /* Original: r.json("{\"foo\":4}").to_json() */
                 var obtained = runOrCatch( r.json("{\"foo\":4}").toJson() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             //JavaDef, json.yaml, #Templates.YamlTest+DefTest.
             //Original: text = '[{"id":1,"first_name":"Harry","last_name":"Riley","email":"hriley0@usgs.gov","country":"Andorra","ip_address":"221.25.65.136"},{"id":2,"first_name":"Bonnie","last_name":"Anderson","email":"banderson1@list-manage.com","country":"Tuvalu","ip_address":"116.162.43.150"},{"id":3,"first_name":"Marie","last_name":"Schmidt","email":"mschmidt2@diigo.com","country":"Iraq","ip_address":"181.105.59.57"},{"id":4,"first_name":"Phillip","last_name":"Willis","email":"pwillis3@com.com","country":"Montenegro","ip_address":"24.223.139.156"}]'
             
String text = (String) ("[{\"id\":1,\"first_name\":\"Harry\",\"last_name\":\"Riley\",\"email\":\"hriley0@usgs.gov\",\"country\":\"Andorra\",\"ip_address\":\"221.25.65.136\"},{\"id\":2,\"first_name\":\"Bonnie\",\"last_name\":\"Anderson\",\"email\":\"banderson1@list-manage.com\",\"country\":\"Tuvalu\",\"ip_address\":\"116.162.43.150\"},{\"id\":3,\"first_name\":\"Marie\",\"last_name\":\"Schmidt\",\"email\":\"mschmidt2@diigo.com\",\"country\":\"Iraq\",\"ip_address\":\"181.105.59.57\"},{\"id\":4,\"first_name\":\"Phillip\",\"last_name\":\"Willis\",\"email\":\"pwillis3@com.com\",\"country\":\"Montenegro\",\"ip_address\":\"24.223.139.156\"}]");             
             
             //JavaDef, json.yaml, #Templates.YamlTest+DefTest.
             //Original: sorted = '[{"country":"Andorra","email":"hriley0@usgs.gov","first_name":"Harry","id":1,"ip_address":"221.25.65.136","last_name":"Riley"},{"country":"Tuvalu","email":"banderson1@list-manage.com","first_name":"Bonnie","id":2,"ip_address":"116.162.43.150","last_name":"Anderson"},{"country":"Iraq","email":"mschmidt2@diigo.com","first_name":"Marie","id":3,"ip_address":"181.105.59.57","last_name":"Schmidt"},{"country":"Montenegro","email":"pwillis3@com.com","first_name":"Phillip","id":4,"ip_address":"24.223.139.156","last_name":"Willis"}]'
             
String sorted = (String) ("[{\"country\":\"Andorra\",\"email\":\"hriley0@usgs.gov\",\"first_name\":\"Harry\",\"id\":1,\"ip_address\":\"221.25.65.136\",\"last_name\":\"Riley\"},{\"country\":\"Tuvalu\",\"email\":\"banderson1@list-manage.com\",\"first_name\":\"Bonnie\",\"id\":2,\"ip_address\":\"116.162.43.150\",\"last_name\":\"Anderson\"},{\"country\":\"Iraq\",\"email\":\"mschmidt2@diigo.com\",\"first_name\":\"Marie\",\"id\":3,\"ip_address\":\"181.105.59.57\",\"last_name\":\"Schmidt\"},{\"country\":\"Montenegro\",\"email\":\"pwillis3@com.com\",\"first_name\":\"Phillip\",\"id\":4,\"ip_address\":\"24.223.139.156\",\"last_name\":\"Willis\"}]");             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #12
                 /* ExpectedOriginal: sorted */
                 var expected = sorted;
                 
                 /* Original: r.json(text).to_json_string() */
                 var obtained = runOrCatch( r.json(text).toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #13
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.minval` to JSON.') */
                 var expected = err("ReqlQueryLogicError", "Cannot convert `r.minval` to JSON.");
                 
                 /* Original: r.expr(r.minval).to_json_string() */
                 var obtained = runOrCatch( r.expr(r.minval()).toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #14
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.maxval` to JSON.') */
                 var expected = err("ReqlQueryLogicError", "Cannot convert `r.maxval` to JSON.");
                 
                 /* Original: r.expr(r.maxval).to_json_string() */
                 var obtained = runOrCatch( r.expr(r.maxval()).toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #15
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.minval` to JSON.') */
                 var expected = err("ReqlQueryLogicError", "Cannot convert `r.minval` to JSON.");
                 
                 /* Original: r.expr(r.minval).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(r.minval()).coerceTo("string") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #16
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot convert `r.maxval` to JSON.') */
                 var expected = err("ReqlQueryLogicError", "Cannot convert `r.maxval` to JSON.");
                 
                 /* Original: r.expr(r.maxval).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(r.maxval()).coerceTo("string") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #17
                 /* ExpectedOriginal: ({'timezone':'+00:00','$reql_type$':'TIME','epoch_time':1410393600}) */
                 var expected = r.hashMap("timezone", "+00:00").with("$reql_type$", "TIME").with("epoch_time", 1410393600);
                 
                 /* Original: r.time(2014,9,11, 'Z') */
                 var obtained = runOrCatch( r.time(2014, 9, 11, "Z") ,
                                            new OptArgs()
                     .with("time_format", "raw")
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #18
                 /* ExpectedOriginal: ('{"$reql_type$":"TIME","epoch_time":1410393600,"timezone":"+00:00"}') */
                 var expected = "{\"$reql_type$\":\"TIME\",\"epoch_time\":1410393600,\"timezone\":\"+00:00\"}";
                 
                 /* Original: r.time(2014,9,11, 'Z').to_json_string() */
                 var obtained = runOrCatch( r.time(2014, 9, 11, "Z").toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #19
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY','coordinates':[0,0],'type':'Point'}) */
                 var expected = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0, 0)).with("type", "Point");
                 
                 /* Original: r.point(0,0) */
                 var obtained = runOrCatch( r.point(0, 0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #20
                 /* ExpectedOriginal: ('{"$reql_type$":"GEOMETRY","coordinates":[0,0],"type":"Point"}') */
                 var expected = "{\"$reql_type$\":\"GEOMETRY\",\"coordinates\":[0,0],\"type\":\"Point\"}";
                 
                 /* Original: r.point(0,0).to_json_string() */
                 var obtained = runOrCatch( r.point(0, 0).toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             //JavaDef, json.yaml, #Templates.YamlTest+DefTest.
             //Original: s = b'\x66\x6f\x6f'
             
byte[] s = (byte[]) (new byte[] { 102,111,111 });             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #22
                 /* ExpectedOriginal: (s) */
                 var expected = s;
                 
                 /* Original: r.binary(s) */
                 var obtained = runOrCatch( r.binary(s) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, json.yaml, #23
                 /* ExpectedOriginal: ('{"$reql_type$":"BINARY","data":"Zm9v"}') */
                 var expected = "{\"$reql_type$\":\"BINARY\",\"data\":\"Zm9v\"}";
                 
                 /* Original: r.expr("foo").coerce_to("binary").to_json_string() */
                 var obtained = runOrCatch( r.expr("foo").coerceTo("binary").toJsonString() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}
