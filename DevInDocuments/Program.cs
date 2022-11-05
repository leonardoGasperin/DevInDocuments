/*###
 *### If change the name on line 10, the welcome frase in line 13 and the bye bye on line 59
 *### the downed box will be disconfigured.
 */

using DevInDocuments.Data;
using DevInDocuments.Entities.Person;
using DevInDocuments.Features;

var _employee = new Employee("Leonardo Vinicius De Gasperin", "Jaridm Porto Belo Nº3000", "EDP technologic Squad",
                             new DateTime(1992, 6, 26), new DateTime(2022,12,24));

GeneralData.InitializeMenu(_employee);
GeneralData.InitializeList();
ScreamMessage.Welcome();
