using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public partial class KnowledgeBase
    {
        private static string GetRequests(string s_NameRequest, string s_Name = "")
        {
            switch (s_NameRequest)
            {
                case "getrootnode":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?process ?label WHERE
                            {?process a cl:Process.
                            ?process rdfs:label ?label.
                            FILTER NOT EXISTS {?process pr:subprocess ?x}.
                            }";
                case "getsubprocess":
                    return @"
                        prefix cl: <URN:classes:stock>
                        prefix pr: <URN:properties:stock>
                        prefix ins: <URN:instanses:stock>
                        prefix owl:<http://www.w3.org/2002/07/owl#>
                        prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                        prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                        SELECT ?process ?label WHERE
                        {?process pr:subprocess " + s_Name + @".
                            ?process rdfs:label ?label.
                        }";
                case "getkpi":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?kpi ?label WHERE
                            {?kpi pr:kpi " + s_Name + @".
                                ?kpi rdfs:label ?label.
                            }";
                case "getexecutors":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?executor ?label WHERE
                            {?executor pr:executor " + s_Name + @".
                                ?executor rdfs:label ?label.
                            }";
                case "getinputs":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?input ?label WHERE
                            {?input pr:input " + s_Name + @".
                                ?input rdfs:label ?label.
                            }";
                case "getoutputs":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?output ?label WHERE
                            {?output pr:output " + s_Name + @".
                                ?output rdfs:label ?label.
                            }";
                default:
                    return "";
            }
        }
    }
}
