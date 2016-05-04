using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Xamarin.Forms.Dynamic
{
	public class CommandsTests
	{
		[Fact]
		public void when_mode_has_command_then_can_execute_it ()
		{
            //			var model = JsonModel.Parse ("", @"{
            //	""Name"": ""Xamarin"",
            //	""$commands"": {
            //		""SetNameCommand"": {
            //			""Name"": ""Rocks!""
            //		}
            //	}
            //}
            //");


            var model = JsonModel.Parse("CharacterPage.xaml", @"

{
  ""CharacterPage.xaml"": {
    ""Character"": {
      ""Name"": ""Scypia the Acolyte"",
      ""CharacterClass"": ""Cleric"",
      ""Alignment"": ""Neutral"",
      ""Level"": 1,
      ""Experience"": 0,
      ""MaxHP"": 7,
      ""CurrentHP"": 7,
      ""HP"": ""7/7"",

      ""Strength"": 9,
      ""Dexterity"": 9,
      ""Constitution"": 14,
      ""Intelligence"": 14,
      ""Wisdom"": 14,
      ""Charisma"": 18,

      ""Breath"": 16,
      ""Poison"": 11,
      ""Petrify"": 14,
      ""Wands"": 12,
      ""Spells"": 15,

      ""ToHit"": 1,
      ""Visible"": false
    }
  },
  ""EditCharacterPage.xaml"": {
    ""Name"": ""Scypia the Acolyte"",
    ""CharacterClass"": ""Cleric"",
    ""Alignments"": [ ""Law"", ""Neutrality"", ""Chaos"" ],
    ""Alignment"": ""Neutral"",
    ""Level"": 1,
    ""Experience"": 0,
    ""MaxHP"": 7,
    ""Strength"": 9,
    ""Dexterity"": 9,
    ""Constitution"": 14,
    ""Intelligence"": 14,
    ""Wisdom"": 14,
    ""Charisma"": 18
  }
  }

            ");

            Assert.Equal ("Xamarin", model.Property ("Name").Value.Value<string> ());

			var info = model.GetTypeInfo ();
			Assert.NotNull (info);

			var prop = info.GetDeclaredProperty ("SetNameCommand");
			Assert.NotNull (prop);

			var command = (ICommand)prop.GetValue (model);
			command.Execute (null);
			
			Assert.Equal ("Rocks!", model.Property ("Name").Value.Value<string> ());
		}
	}
}
