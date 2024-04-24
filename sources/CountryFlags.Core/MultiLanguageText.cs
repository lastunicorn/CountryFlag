// Country Flags
// Copyright (C) 2022-2024 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.ObjectModel;

namespace DustInTheWind.CountryFlags;

public class MultiLanguageText : Collection<Translation>
{
    public string? DefaultTranslation
    {
        get
        {
            return Items
                .Where(x => x.Language == "english")
                .Select(x => x.Text)
                .FirstOrDefault();
        }
    }

    public string? Comments { get; set; }

    public MultiLanguageText()
    {
    }

    public MultiLanguageText(IEnumerable<Translation> translations)
    {
        foreach (Translation translation in translations)
            Items.Add(translation);
    }

    public static implicit operator MultiLanguageText(string text)
    {
        MultiLanguageText multiLanguageText = new();
        Translation translation = text;
        multiLanguageText.Add(translation);

        return multiLanguageText;
    }

    public static implicit operator MultiLanguageText(Translation translation)
    {
        return new MultiLanguageText
        {
            translation
        };
    }

    public static implicit operator MultiLanguageText(TranslationNote translationNote)
    {
        MultiLanguageText multiLanguageText = new()
        {
            new Translation
            {
                Text = translationNote.Text,
                Language = translationNote.Language,
                Phonetic = translationNote.Phonetic,
                Romanized = translationNote.Romanized
            },
            new Translation
            {
                Text = translationNote.EnglishTranslation,
                Language = "english"
            }
        };

        multiLanguageText.Comments = translationNote.Comments;

        return multiLanguageText;
    }
}