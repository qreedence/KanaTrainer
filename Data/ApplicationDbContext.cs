using Microsoft.EntityFrameworkCore;
using KanaTrainer.Data.Models;

namespace KanaTrainer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kana> Kanas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kana>().HasData(
            #region "Seed Data"
            #region "Hiragana"
                //Hiragana
                new Kana { KanaOriginal = "あ", KanaRomaji = "a", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "い", KanaRomaji = "i", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "う", KanaRomaji = "u", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "え", KanaRomaji = "e", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "お", KanaRomaji = "o", KanaType = "Hiragana" },
                
                new Kana { KanaOriginal = "か", KanaRomaji = "ka", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "き", KanaRomaji = "ki", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "く", KanaRomaji = "ku", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "け", KanaRomaji = "ke", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "こ", KanaRomaji = "ko", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "さ", KanaRomaji = "sa", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "し", KanaRomaji = "shi", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "す", KanaRomaji = "su", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "せ", KanaRomaji = "se", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "そ", KanaRomaji = "so", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "た", KanaRomaji = "ta", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ち", KanaRomaji = "chi", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "つ", KanaRomaji = "tsu", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "て", KanaRomaji = "te", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "と", KanaRomaji = "to", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "な", KanaRomaji = "na", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "に", KanaRomaji = "ni", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ぬ", KanaRomaji = "nu", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ね", KanaRomaji = "ne", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "の", KanaRomaji = "no", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "は", KanaRomaji = "ha", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ひ", KanaRomaji = "hi", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ふ", KanaRomaji = "fu", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "へ", KanaRomaji = "he", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ほ", KanaRomaji = "ho", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "ま", KanaRomaji = "ma", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "み", KanaRomaji = "mi", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "む", KanaRomaji = "mu", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "め", KanaRomaji = "me", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "も", KanaRomaji = "mo", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "や", KanaRomaji = "ya", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ゆ", KanaRomaji = "yu", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "よ", KanaRomaji = "yo", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "ら", KanaRomaji = "ra", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "り", KanaRomaji = "ri", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "る", KanaRomaji = "ru", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "れ", KanaRomaji = "re", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ろ", KanaRomaji = "ro", KanaType = "Hiragana" },

                new Kana { KanaOriginal = "わ", KanaRomaji = "wa", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "を", KanaRomaji = "wo", KanaType = "Hiragana" },
                //Hiragana Dakuon
                new Kana { KanaOriginal = "が", KanaRomaji = "ga", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ぎ", KanaRomaji = "gi", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ぐ", KanaRomaji = "gu", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "げ", KanaRomaji = "ge", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ご", KanaRomaji = "go", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ざ", KanaRomaji = "za", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "じ", KanaRomaji = "ji", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ず", KanaRomaji = "zu", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ぜ", KanaRomaji = "ze", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ぞ", KanaRomaji = "zo", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "だ", KanaRomaji = "da", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ぢ", KanaRomaji = "ji", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "づ", KanaRomaji = "zu", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "で", KanaRomaji = "de", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ど", KanaRomaji = "do", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ば", KanaRomaji = "ba", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "び", KanaRomaji = "bi", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ぶ", KanaRomaji = "bu", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "べ", KanaRomaji = "be", KanaType = "Hiragana Dakuon" },
                new Kana { KanaOriginal = "ぼ", KanaRomaji = "bo", KanaType = "Hiragana Dakuon" },

                //Hiragana Handakuon
                new Kana { KanaOriginal = "ぱ", KanaRomaji = "pa", KanaType = "Hiragana Handakuon" },
                new Kana { KanaOriginal = "ぴ", KanaRomaji = "pi", KanaType = "Hiragana Handakuon" },
                new Kana { KanaOriginal = "ぷ", KanaRomaji = "pu", KanaType = "Hiragana Handakuon" },
                new Kana { KanaOriginal = "ぺ", KanaRomaji = "pe", KanaType = "Hiragana Handakuon" },
                new Kana { KanaOriginal = "ぽ", KanaRomaji = "po", KanaType = "Hiragana Handakuon" },

                //Hiragana Yōon
                new Kana { KanaOriginal = "きゃ", KanaRomaji = "kya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "きゅ", KanaRomaji = "kyu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "きょ", KanaRomaji = "kyo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "しゃ", KanaRomaji = "sha", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "しゅ", KanaRomaji = "shu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "しょ", KanaRomaji = "sho", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ちゃ", KanaRomaji = "cha", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ちゅ", KanaRomaji = "chu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ちょ", KanaRomaji = "cho", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "にゃ", KanaRomaji = "nya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "にゅ", KanaRomaji = "nyu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "にょ", KanaRomaji = "nyo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ひゃ", KanaRomaji = "hya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ひゅ", KanaRomaji = "hyu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ひょ", KanaRomaji = "hyo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "みゃ", KanaRomaji = "mya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "みゅ", KanaRomaji = "myu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "みょ", KanaRomaji = "myo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "りゃ", KanaRomaji = "rya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "りゅ", KanaRomaji = "ryu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "りょ", KanaRomaji = "ryo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぎゃ", KanaRomaji = "gya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぎゅ", KanaRomaji = "gyu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぎょ", KanaRomaji = "gyo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "じゃ", KanaRomaji = "ja", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "じゅ", KanaRomaji = "ju", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "じょ", KanaRomaji = "jo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぢゃ", KanaRomaji = "ja", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぢゅ", KanaRomaji = "ju", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぢょ", KanaRomaji = "jo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "びゃ", KanaRomaji = "bya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "びゅ", KanaRomaji = "byu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "びょ", KanaRomaji = "byo", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぴゃ", KanaRomaji = "pya", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぴゅ", KanaRomaji = "pyu", KanaType = "Hiragana Yōon" },
                new Kana { KanaOriginal = "ぴょ", KanaRomaji = "pyo", KanaType = "Hiragana Yōon" },
            #endregion
            #region "Katakana"

                //Katakana
                new Kana { KanaOriginal = "ん", KanaRomaji = "n", KanaType = "Hiragana" },
                new Kana { KanaOriginal = "ア", KanaRomaji = "a", KanaType = "Katakana" },
                new Kana { KanaOriginal = "イ", KanaRomaji = "i", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ウ", KanaRomaji = "u", KanaType = "Katakana" },
                new Kana { KanaOriginal = "エ", KanaRomaji = "e", KanaType = "Katakana" },
                new Kana { KanaOriginal = "オ", KanaRomaji = "o", KanaType = "Katakana" },

                new Kana { KanaOriginal = "カ", KanaRomaji = "ka", KanaType = "Katakana" },
                new Kana { KanaOriginal = "キ", KanaRomaji = "ki", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ク", KanaRomaji = "ku", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ケ", KanaRomaji = "ke", KanaType = "Katakana" },
                new Kana { KanaOriginal = "コ", KanaRomaji = "ko", KanaType = "Katakana" },

                new Kana { KanaOriginal = "サ", KanaRomaji = "sa", KanaType = "Katakana" },
                new Kana { KanaOriginal = "シ", KanaRomaji = "shi", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ス", KanaRomaji = "su", KanaType = "Katakana" },
                new Kana { KanaOriginal = "セ", KanaRomaji = "se", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ソ", KanaRomaji = "so", KanaType = "Katakana" },

                new Kana { KanaOriginal = "タ", KanaRomaji = "ta", KanaType = "Katakana" },
                new Kana { KanaOriginal = "チ", KanaRomaji = "chi", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ツ", KanaRomaji = "tsu", KanaType = "Katakana" },
                new Kana { KanaOriginal = "テ", KanaRomaji = "te", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ト", KanaRomaji = "to", KanaType = "Katakana" },

                new Kana { KanaOriginal = "ナ", KanaRomaji = "na", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ニ", KanaRomaji = "ni", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ヌ", KanaRomaji = "nu", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ネ", KanaRomaji = "ne", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ノ", KanaRomaji = "no", KanaType = "Katakana" },

                new Kana { KanaOriginal = "ハ", KanaRomaji = "ha", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ヒ", KanaRomaji = "hi", KanaType = "Katakana" },
                new Kana { KanaOriginal = "フ", KanaRomaji = "fu", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ヘ", KanaRomaji = "he", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ホ", KanaRomaji = "ho", KanaType = "Katakana" },

                new Kana { KanaOriginal = "マ", KanaRomaji = "ma", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ミ", KanaRomaji = "mi", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ム", KanaRomaji = "mu", KanaType = "Katakana" },
                new Kana { KanaOriginal = "メ", KanaRomaji = "me", KanaType = "Katakana" },
                new Kana { KanaOriginal = "モ", KanaRomaji = "mo", KanaType = "Katakana" },

                new Kana { KanaOriginal = "ヤ", KanaRomaji = "ya", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ユ", KanaRomaji = "yu", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ヨ", KanaRomaji = "yo", KanaType = "Katakana" },

                new Kana { KanaOriginal = "ラ", KanaRomaji = "ra", KanaType = "Katakana" },
                new Kana { KanaOriginal = "リ", KanaRomaji = "ri", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ル", KanaRomaji = "ru", KanaType = "Katakana" },
                new Kana { KanaOriginal = "レ", KanaRomaji = "re", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ロ", KanaRomaji = "ro", KanaType = "Katakana" },

                new Kana { KanaOriginal = "ワ", KanaRomaji = "wa", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ヲ", KanaRomaji = "wo", KanaType = "Katakana" },
                new Kana { KanaOriginal = "ン", KanaRomaji = "n", KanaType = "Katakana" },

                //Katakana Dakuon
                new Kana { KanaOriginal = "ガ", KanaRomaji = "ga", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ギ", KanaRomaji = "gi", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "グ", KanaRomaji = "gu", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ゲ", KanaRomaji = "ge", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ゴ", KanaRomaji = "go", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ザ", KanaRomaji = "za", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ジ", KanaRomaji = "ji", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ズ", KanaRomaji = "zu", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ゼ", KanaRomaji = "ze", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ゾ", KanaRomaji = "zo", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ダ", KanaRomaji = "da", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ヂ", KanaRomaji = "ji", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ヅ", KanaRomaji = "zu", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "デ", KanaRomaji = "de", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ド", KanaRomaji = "do", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "バ", KanaRomaji = "ba", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ビ", KanaRomaji = "bi", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ブ", KanaRomaji = "bu", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ベ", KanaRomaji = "be", KanaType = "Katakana Dakuon" },
                new Kana { KanaOriginal = "ボ", KanaRomaji = "bo", KanaType = "Katakana Dakuon" },

                //Katakana Handakuon
                new Kana { KanaOriginal = "パ", KanaRomaji = "pa", KanaType = "Katakana Handakuon" },
                new Kana { KanaOriginal = "ピ", KanaRomaji = "pi", KanaType = "Katakana Handakuon" },
                new Kana { KanaOriginal = "プ", KanaRomaji = "pu", KanaType = "Katakana Handakuon" },
                new Kana { KanaOriginal = "ペ", KanaRomaji = "pe", KanaType = "Katakana Handakuon" },
                new Kana { KanaOriginal = "ポ", KanaRomaji = "po", KanaType = "Katakana Handakuon" },

                //Katakana Yoon
                new Kana { KanaOriginal = "キャ", KanaRomaji = "kya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "キュ", KanaRomaji = "kyu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "キョ", KanaRomaji = "kyo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "シャ", KanaRomaji = "sha", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "シュ", KanaRomaji = "shu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ショ", KanaRomaji = "sho", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "チャ", KanaRomaji = "cha", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "チュ", KanaRomaji = "chu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "チョ", KanaRomaji = "cho", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ニャ", KanaRomaji = "nya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ニュ", KanaRomaji = "nyu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ニョ", KanaRomaji = "nyo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ヒャ", KanaRomaji = "hya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ヒュ", KanaRomaji = "hyu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ヒョ", KanaRomaji = "hyo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ミャ", KanaRomaji = "mya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ミュ", KanaRomaji = "myu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ミョ", KanaRomaji = "myo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "リャ", KanaRomaji = "rya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "リュ", KanaRomaji = "ryu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "リョ", KanaRomaji = "ryo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ギャ", KanaRomaji = "gya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ギュ", KanaRomaji = "gyu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ギョ", KanaRomaji = "gyo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ジャ", KanaRomaji = "ja", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ジュ", KanaRomaji = "ju", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ジョ", KanaRomaji = "jo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ヂャ", KanaRomaji = "ja", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ヂュ", KanaRomaji = "ju", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ヂョ", KanaRomaji = "jo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ビャ", KanaRomaji = "bya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ビュ", KanaRomaji = "byu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ビョ", KanaRomaji = "byo", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ピャ", KanaRomaji = "pya", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ピュ", KanaRomaji = "pyu", KanaType = "Katakana Yōon" },
                new Kana { KanaOriginal = "ピョ", KanaRomaji = "pyo", KanaType = "Katakana Yōon" }
                );
            #endregion
            #endregion
        }
    }
}
