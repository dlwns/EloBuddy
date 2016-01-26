﻿using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EloBuddy.SDK.Menu.Values;
using KoreanAIO.Managers;

namespace KoreanAIO.Utilities
{
    public enum Language
    {
        English,
        Spanish,
        French,
        German,
        Italian,
        Portuguese,
        Polish,
        Turkish,
        Chinese,
        ChineseTraditional,
        Korean
    }

    public static class LanguageTranslator
    {
        private static readonly Dictionary<Language, Dictionary<string, string>> Translations =
            new Dictionary<Language, Dictionary<string, string>>();

        private static readonly Dictionary<string, Language> CulturesToLanguage = new Dictionary<string, Language>
        {
            {"en-US", Language.English},
            {"en-GB", Language.English},
            {"es-ES", Language.Spanish},
            {"fr-FR", Language.French},
            {"de-DE", Language.German},
            {"it-IT", Language.Italian},
            {"pt-BR", Language.Portuguese},
            {"pt-PT", Language.Portuguese},
            {"pl-PL", Language.Polish},
            {"tr-TR", Language.Turkish},
            {"zh-CHS", Language.Chinese},
            {"zh-CHT", Language.ChineseTraditional},
            {"ko-KR", Language.Korean}
        };

        static LanguageTranslator()
        {
            Translations[Language.English] = new Dictionary<string, string>
            {
                {"Language", "Language"},
                {"English", "English" /* Spanish = Espanol (for ex)*/},
                {"Enabled", "Enabled"},
                {"Disabled", "Disabled"},
                {"Available", "Available"},
                /* Keys */
                {"Combo.WithoutR", "Combo without R"},
                {"Harass.WEQ", "Harass WEQ"},
                /* Toggles */
                {"LastHit.Toggle", "LastHit Toggle"},
                {"Harass.Toggle", "Harass Toggle"},
                /* Submenus */
                {"Keys", "Keys"},
                {"Prediction", "Prediction"},
                {"Combo", "Combo"},
                {"Harass", "Harass"},
                {"Clear", "Clear"},
                {"LaneClear", "LaneClear"},
                {"LastHit", "LastHit"},
                {"JungleClear", "JungleClear"},
                {"KillSteal", "KillSteal"},
                {"Automatic", "Automatic"},
                {"Evader", "Evader"},
                {"Drawings", "Drawings"},
                {"Flee", "Flee"},
                {"Misc", "Misc"},
                /* LastHit */
                {"Never", "Never"},
                {"Smartly", "Smartly"},
                {"Always", "Always"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "Minimum Mana Percent"},
                {"DisableUnderEnemyTurret", "Disable under enemy turret"},
                {"IfKillable", "If killable"},
                {"IfNeeded", "If needed"},
                {"UseIgnite", "Use Ignite"},
                {"UseIgnite.Killable", "Use Ignite if target is killable"},
                {"UseSmite", "Use Smite"},
                {"UseQ", "Use Q"},
                {"UseQ.Hit", "Use Q if hit is greater than {0}"},
                {"UseQ.Gapcloser", "Use Q on hero gapclosing / dashing"},
                {"UseQ.Interrupter", "Use Q on channeling spells"},
                {"UseW", "Use W"},
                {"UseW.Hit", "Use W if hit is greater than {0}"},
                {"UseW.Gapcloser", "Use W on hero gapclosing / dashing"},
                {"UseW.Interrupter", "Use W on channeling spells"},
                {"UseE", "Use E"},
                {"UseE.Hit", "Use E if hit is greater than {0}"},
                {"UseE.Gapcloser", "Use E on hero gapclosing / dashing"},
                {"UseE.Interrupter", "Use E on channeling spells"},
                {"UseR", "Use R"},
                {"UseR.Killable", "Use R if target is killable"},
                {"UseR.Hit", "Use R if hit is greater than {0}"},
                {"UseR.Gapcloser", "Use R on hero gapclosing / dashing"},
                {"UseR.Interrupter", "Use R on channeling spells"},
                {"R.BlackList", "Don't use R on:"},
                {"Items", "Use offensive items"},
                {"Zhonyas", "Use Zhonyas if my % of health is less than {0}"},
                /* Zed */
                {"R.Prevent", "Don't use spells before R"},
                {"R.Combo.Mode", "R Combo Mode"},
                {"UseQ.Collision", "Check collision when casting Q (more damage)"},
                {"UseW1", "Use W1"},
                {"UseW2", "Use W2"},
                {"UseR1", "Use R1"},
                {"UseR2", "Use R2"},
                {"SwapDead", "Use W2/R2 if target will die"},
                {"SwapGapclose", "Use W2/R2 to get close to target"},
                {"SwapKillable", "Use W2 if target is killable"},
                {"SwapHP", "Use W2/R2 if my % of health is less than {0}"},
                {"Line", "Line"},
                {"Triangle", "Triangle"},
                {"MousePos", "MousePos"},
                {"IsDead", "Is Dead"},
                {"Passive", "Passive"},
                {"Draw.WShadow", "Draw W shadow circle"},
                {"Draw.RShadow", "Draw R shadow circle"},
                {"Draw.TargetIsDead", "Draw text if target will die"},
                {"Draw.PassiveIsReady", "Draw text when passive is available"},
                /* Cassiopeia */
                {"Poisoned", "If Poisoned"},
                {"AssistedUltimate", "Assisted Ultimate"},
                /* Diana */
                {"UseQR", "Use QR on minion to gapclose"},
                {"R.2nd", "Use always second r"},
                /* Orianna */
                {"TeamFight.Count", "Use TeamFight logic if enemies near is greater than {0}"},
                {"Common.Logic", "Common logic"},
                {"1vs1.Logic", "1 vs 1 logic"},
                {"TeamFight.Logic", "TeamFight logic"},
                {"UseE.HealthPercent", "Use E if my % of health is less than {0}"},
                {"UseE.Spells", "Use E on enemy spells"},
                {"Draw.Ball", "Draw ball position"},
                {"R.Block", "Block R if will not hit"},
                /* Drawings */
                {"Draw.Disable", "Disable all drawings"},
                {"Draw.DamageIndicator", "Draw damage indicator"},
                {"Draw.Target", "Draw circle on target"},
                {"Draw.Q", "Draw Q range"},
                {"Draw.W", "Draw W range"},
                {"Draw.E", "Draw E range"},
                {"Draw.R", "Draw R range"},
                {"Draw.Toggles", "Draw toggles status"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: HitChancePercent"},
                {"W.HitChancePercent", "W: HitChancePercent"},
                {"E.HitChancePercent", "E: HitChancePercent"},
                {"QE.HitChancePercent", "QE: HitChancePercent"},
                {"R.HitChancePercent", "R: HitChancePercent"}
            };
            Translations[Language.Spanish] = new Dictionary<string, string>
            {
                {"Language", "Idioma"},
                {"Spanish", "Español"},
                {"Enabled", "Activado"},
                {"Disabled", "Desactivado"},
                {"Available", "Disponible"},
                /* Keys */
                {"Combo.WithoutR", "Combate sin R"},
                {"Harass.WEQ", "Acoso WEQ"},
                /* Toggles */
                {"LastHit.Toggle", "Interruptor último golpe"},
                {"Harass.Toggle", "Interruptor acoso"},
                /* Submenus */
                {"Keys", "Teclas"},
                {"Prediction", "Predicción"},
                {"Combo", "Combate"},
                {"Harass", "Acoso"},
                {"Clear", "Farmear"},
                {"LaneClear", "Limpiar la linea"},
                {"LastHit", "Último golpe"},
                {"JungleClear", "Limpiar la jungla"},
                {"KillSteal", "KillSteal"},
                {"Automatic", "Automático"},
                {"Evader", "Evadir"},
                {"Drawings", "Dibujos"},
                {"Flee", "Escape"},
                {"Misc", "Misceláneo"},
                /* LastHit */
                {"Never", "Nunca"},
                {"Smartly", "Inteligentemente"},
                {"Always", "Siempre"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "Mínimo porcentaje de mana"},
                {"DisableUnderEnemyTurret", "Desactivar bajo torre enemiga"},
                {"IfKillable", "Si es matable"},
                {"IfNeeded", "Si se requiere"},
                {"UseIgnite", "Usar Ignición"},
                {"UseIgnite.Killable", "Usar Ignición si el objetivo es matable"},
                {"UseSmite", "Usar Castigo"},
                {"UseQ", "Usar Q"},
                {"UseQ.Hit", "Usar Q si golpea a más de {0}"},
                {"UseQ.Gapcloser", "Usar Q en campeones que estén corriendo"},
                {"UseQ.Interrupter", "Usar Q en campeones canalizando"},
                {"UseW", "Usar W"},
                {"UseW.Hit", "Usar W si golpea a más de {0}"},
                {"UseW.Gapcloser", "Usar W en campeones que estén corriendo"},
                {"UseW.Interrupter", "Usar W en campeones canalizando"},
                {"UseE", "Usar E"},
                {"UseE.Hit", "Usar E si golpea a más de {0}"},
                {"UseE.Gapcloser", "Usar E en campeones que estén corriendo"},
                {"UseE.Interrupter", "Usar E en campeones canalizando"},
                {"UseR", "Usar R"},
                {"UseR.Killable", "Usar R si el objetivo es matable"},
                {"UseR.Hit", "Usar R si golpea a más de {0}"},
                {"UseR.Gapcloser", "Usar R en campeones que estén corriendo"},
                {"UseR.Interrupter", "Usar R en campeones canalizando"},
                {"R.BlackList", "No usar la R contra:"},
                {"Items", "Use items ofensivos"},
                {"Zhonyas", "Usar Zhonyas si mi % de vida es menor a {0}"},
                /* Zed */
                {"R.Prevent", "No usar habilidades antes de la R"},
                {"R.Combo.Mode", "Modo de combate con la R"},
                {"UseQ.Collision", "Chequear colisión al castear la Q (más daño)"},
                {"UseW1", "Usar W1"},
                {"UseW2", "Usar W2"},
                {"UseR1", "Usar R1"},
                {"UseR2", "Usar R2"},
                {"SwapDead", "Usar W2/R2 si el objetivo va a morir"},
                {"SwapGapclose", "Usar W2/R2 para acercarse al objetivo"},
                {"SwapKillable", "Usar W2 si el objetivo es matable"},
                {"SwapHP", "Usar W2/R2 si mi % de vida es menor a {0}"},
                {"Line", "Línea"},
                {"Triangle", "Triángulo"},
                {"MousePos", "Posición del mouse"},
                {"IsDead", "Está muerto"},
                {"Passive", "Pasiva"},
                {"Draw.WShadow", "Dibujar un circulo sobre la sombra de la W"},
                {"Draw.RShadow", "Dibujar un circulo sobre la sombra de la R"},
                {"Draw.TargetIsDead", "Dibujar texto is el objetivo va a morir"},
                {"Draw.PassiveIsReady", "Dibujar texto si la pasiva está disponible"},
                /* Cassiopeia */
                {"Poisoned", "Si está envenenado"},
                {"AssistedUltimate", "R asistida"},
                /* Diana */
                {"UseQR", "Usar QR en minions para acercarse"},
                {"R.2nd", "Usar siempre la segunda R"},
                /* Orianna */
                {"TeamFight.Count", "Usar lógica de TeamFight si los enemigos son más de {0}"},
                {"Common.Logic", "Lógica comun"},
                {"1vs1.Logic", "Lógica 1 versus 1"},
                {"TeamFight.Logic", "Lógica de TeamFight"},
                {"UseE.HealthPercent", "Usar E si mi % de vida es menor a {0}"},
                {"UseE.Spells", "Usar E contra habilidades del enemigo"},
                {"Draw.Ball", "Dibujar un circulo sobre la bola"},
                {"R.Block", "Bloquear la R si no va a golpear"},
                /* Drawings */
                {"Draw.Disable", "Desactivar todos los dibujos"},
                {"Draw.DamageIndicator", "Dibujar indicador de daño"},
                {"Draw.Target", "Dibujar circulo sobre el objetivo"},
                {"Draw.Q", "Dibujar el rango de la Q"},
                {"Draw.W", "Dibujar el rango de la W"},
                {"Draw.E", "Dibujar el rango de la E"},
                {"Draw.R", "Dibujar el rango de la R"},
                {"Draw.Toggles", "Dibujar el estado de los interruptores"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: Porcentaje de probabilidad de golpe"},
                {"W.HitChancePercent", "W: Porcentaje de probabilidad de golpe"},
                {"E.HitChancePercent", "E: Porcentaje de probabilidad de golpe"},
                {"QE.HitChancePercent", "QE: Porcentaje de probabilidad de golpe"},
                {"R.HitChancePercent", "R: Porcentaje de probabilidad de golpe"}
            };
            Translations[Language.German] = new Dictionary<string, string>
            {
                {"Language", "Sprache"},
                {"German", "Deutsch"},
                {"Enabled", "Aktiviert"},
                {"Disabled", "Deaktiviert"},
                {"Available", "Verfügbar"},
                /* Keys */
                {"Combo.WithoutR", "Combo ohne R"},
                {"Harass.WEQ", "Harass WEQ"},
                /* Toggles */
                {"LastHit.Toggle", "LastHit Toggle"},
                {"Harass.Toggle", "Harass Toggle"},
                /* Submenus */
                {"Keys", "Tasten"},
                {"Prediction", "Prediction"},
                {"Combo", "Combo"},
                {"Harass", "Harass"},
                {"Clear", "Clear"},
                {"LaneClear", "LaneClear"},
                {"LastHit", "LastHit"},
                {"JungleClear", "JungleClear"},
                {"KillSteal", "KillSteal"},
                {"Automatic", "Automatic"},
                {"Evader", "Evader"},
                {"Drawings", "Drawings"},
                {"Flee", "Flee"},
                {"Misc", "Verschiedenes"},
                /* LastHit */
                {"Never", "Nie"},
                {"Smartly", "Intelligent"},
                {"Always", "Immer"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "Minimale Mana Prozent"},
                {"DisableUnderEnemyTurret", "Deaktivieren unter feindlichen Türmen"},
                {"IfKillable", "Wenn Ziel sterben könnte"},
                {"IfNeeded", "Falls gebraucht"},
                {"UseIgnite", "Benutze Ignite"},
                {"UseIgnite.Killable", "Benutze ignite wenn Ziel sterben könnte"},
                {"UseSmite", "Benutze Smite"},
                {"UseQ", "Benutze Q"},
                {"UseQ.Hit", "Benutze Q wenn mehr als {0} getroffen werden"},
                {"UseQ.Gapcloser", "Benutze Q gegen dashes/gapcloser"},
                {"UseQ.Interrupter", "Benutze Q um Zauber zu unterbrechen"},
                {"UseW", "Benutze W"},
                {"UseW.Hit", "Benutze W wenn mehr als {0} getroffen werden"},
                {"UseW.Gapcloser", "Benutze W gegen dashes/gapcloser"},
                {"UseW.Interrupter", "Benutze W um Zauber zu unterbrechen"},
                {"UseE", "Benutze E"},
                {"UseE.Hit", "Benutze E wenn mehr als {0} getroffen werden"},
                {"UseE.Gapcloser", "Benutze E gegen dashes/gapcloser"},
                {"UseE.Interrupter", "Benutze E um Zauber zu unterbrechen"},
                {"UseR", "Benutze R"},
                {"UseR.Killable", "Benutze R wenn Ziel sterben kann"},
                {"UseR.Hit", "Benutze R wenn mehr als {0} getroffen werden"},
                {"UseR.Gapcloser", "Benutze R gegen dashes/gapcloser"},
                {"UseR.Interrupter", "Benutze R um Zauber zu unterbrechen"},
                {"R.BlackList", "Nutze R nicht gegen:"},
                {"Items", "Benutze offensive Gegenstände"},
                {"Zhonyas", "Benutze Zhonyas wenn meine HP weniger als {0} sind"},
                /* Zed */
                {"R.Prevent", "Blockiere Zauber wenn R bereit ist"},
                {"R.Combo.Mode", "R Combo Mode"},
                {"UseQ.Collision", "Benutze Q nur ohne Collision (mehr Schaden)"},
                {"UseW1", "Nutze W1"},
                {"UseW2", "Nutze W2"},
                {"UseR1", "Nutze R1"},
                {"UseR2", "Nutze R2"},
                {"SwapDead", "Benutze W2/R2 wenn das Ziel sterben wird"},
                {"SwapGapclose", "Benutze W2/R2 um Ziel näher zu kommen"},
                {"SwapKillable", "Benutze W2 wenn das Ziel sterben könnte"},
                {"SwapHP", "Benutze W2/R2 wenn mein Leben in % kleiner als {0} ist"},
                {"Line", "Linie"},
                {"Triangle", "Dreieck"},
                {"MousePos", "Maus Position"},
                {"IsDead", "Ist tot"},
                {"Passive", "Passive"},
                {"Draw.WShadow", "zeichne W Schatten"},
                {"Draw.RShadow", "zeichne R Schatten"},
                {"Draw.TargetIsDead", "zeichne Text wenn Ziel sterben wird"},
                {"Draw.PassiveIsReady", "zeichne Text wenn Passive bereit ist"},
                /* Cassiopeia */
                {"Poisoned", "Wenn vergiftet"},
                {"AssistedUltimate", "Assistierter Ult"},
                /* Diana */
                {"UseQR", "Benutze QR gegen minions um Ziel nahe zu kommen"},
                {"R.2nd", "Beutze 2. R immer"},
                /* Orianna */
                {"TeamFight.Count", "Benutze Teamfight Logik wenn mehr als {0} Feinde nahe"},
                {"Common.Logic", "Standard Logik"},
                {"1vs1.Logic", "1 vs 1 Logik"},
                {"TeamFight.Logic", "TeamFight Logik"},
                {"UseE.HealthPercent", "Benutze E wenn meine HP % kleiner als {0}"},
                {"UseE.Spells", "Benutze E gegen feindliche Zauber"},
                {"Draw.Ball", "Zeichne Ball Position"},
                {"R.Block", "Blockiere R wenn kein Feind getroffen wird"},
                /* Drawings */
                {"Draw.Disable", "Deaktiviere alle Zeichnungen (Drawings)"},
                {"Draw.DamageIndicator", "Zeichne voraussichtlichen Schaden"},
                {"Draw.Target", "Zeichne einen Kreis um das Ziel"},
                {"Draw.Q", "Zeichne Q Reichweite"},
                {"Draw.W", "Zeichne W Reichweite"},
                {"Draw.E", "Zeichne E Reichweite"},
                {"Draw.R", "Zeichne R Reichweite"},
                {"Draw.Toggles", "Zeichne Harass/Combo Status"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: Chance zu treffen in %"},
                {"W.HitChancePercent", "W: Chance zu treffen in %"},
                {"E.HitChancePercent", "E: Chance zu treffen in %"},
                {"QE.HitChancePercent", "QE: Chance zu treffen in %"},
                {"R.HitChancePercent", "R: Chance zu treffen in %"}
            };
            Translations[Language.Polish] = new Dictionary<string, string>
            {
                {"Language", "Język"},
                {"Polish", "Polski"},
                {"Enabled", "Włączony"},
                {"Disabled", "Wyłączony"},
                /* Keys */
                {"Combo.WithoutR", "Combo bez R"},
                {"Harass.WEQ", "Harass WEQ"},
                /* Toggles */
                {"LastHit.Toggle", "LastHit Włączony"},
                {"Harass.Toggle", "Harass Włączony"},
                /* Submenus */
                {"Keys", "Przyciski"},
                {"Prediction", "Predykcja"},
                {"Combo", "Combo"},
                {"Harass", "Harass"},
                {"Clear", "Clear"},
                {"LaneClear", "LaneClear"},
                {"LastHit", "LastHit"},
                {"JungleClear", "JungleClear"},
                {"KillSteal", "KillSteal"},
                {"Automatic", "Automatyczny"},
                {"Evader", "Evader"},
                {"Drawings", "Rysowania"},
                {"Flee", "Ucieczka"},
                {"Misc", "Inne"},
                /* LastHit */
                {"Never", "Nigdy"},
                {"Smartly", "Ograniczony"},
                {"Always", "Zawsze"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "Minimalny Procent Many"},
                {"DisableUnderEnemyTurret", "Wyłączone gdy przeciwnik jest pod wieżą"},
                {"IfKillable", "Jeśli jest do zabicia"},
                {"IfNeeded", "Jeśli potrzebny"},
                {"UseIgnite", "Użyj podpalenia"},
                {"UseIgnite.Killable", "Użyj podpalenia gdy przeciwnik jest do zabicia"},
                {"UseSmite", "Użyj porażenia"},
                {"UseQ", "Użyj Q"},
                {"UseQ.Hit", "Użyj Q gdy może trafić więcej celów niż {0}"},
                {"UseQ.Gapcloser", "Użyj Q na postać gapclosing / dashing"},
                {"UseQ.Interrupter", "Użyj Q na kanałowe umiejętności"},
                {"UseW", "Użyj W"},
                {"UseW.Hit", "Użyj W gdy może trafić więcej celów niż {0}"},
                {"UseW.Gapcloser", "Użyj W na postać gapclosing / dashing"},
                {"UseW.Interrupter", "Użyj W na kanałowe umiejętności"},
                {"UseE", "Użyj E"},
                {"UseE.Hit", "Użyj E gdy może trafić więcej celów niż {0}"},
                {"UseE.Gapcloser", "Użyj E na postacie gapclosing / dashing"},
                {"UseE.Interrupter", "Użyj E na kanałowe umiejętności"},
                {"UseR", "Użyj R"},
                {"UseR.Killable", "Użyj R jeśli cel zginie"},
                {"UseR.Hit", "Użyj R gdy może trafić więcej celów {0}"},
                {"UseR.Gapcloser", "Użyj R na postacie gapclosing / dashing"},
                {"UseR.Interrupter", "Użyj R na kanałowe umiejętności"},
                {"R.BlackList", "Nie używaj R na:"},
                {"Items", "Użyj ofensywnych przedmiotów"},
                {"Zhonyas", "Użyj Zhonyas gdy % życia jest niższe od {0}"},
                /* Zed */
                {"R.Prevent", "Nie używaj umiejętności przed użyciem R"},
                {"R.Combo.Mode", "R Tryb Combo"},
                {"UseQ.Collision", "Sprawdź kolizję przed użyciem Q (więcej obrażeń)"},
                {"UseW1", "Użyj W1"},
                {"UseW2", "Użyj W2"},
                {"UseR1", "Użyj R1"},
                {"UseR2", "Użyj R2"},
                {"SwapDead", "Użyj W2/R2 jeśli cel zginie"},
                {"SwapGapclose", "Użyj W2/R2 aby zbliżyć się do celu"},
                {"SwapKillable", "Użyj W2 jeśli cel jest martwy"},
                {"SwapHP", "Użyj W2/R2 jeśli % mojego zdrowia jest niższy od {0}"},
                {"Line", "Liniowy"},
                {"Triangle", "Trójkątny"},
                {"MousePos", "PozycjaMyszy"},
                {"Draw.WShadow", "Pokaż W cień okrąg"},
                {"Draw.RShadow", "Pokaż R cień okrąg"},
                {"Draw.TargetIsDead", "Pokaż tekst gdy cel jest martwy"},
                {"Draw.PassiveIsReady", "Pokaż tekst gdy pasywna umiejętność jest gotowa"},
                /* Cassiopeia */
                {"Poisoned", "Jeśli zatruty"},
                {"AssistedUltimate", "Asystent Ultimate"},
                /* Diana */
                {"UseQR", "Użyj QR na miniony aby się zbliżyć"},
                {"R.2nd", "Użyj zawsze pierwsze R"},
                /* Orianna */
                {"TeamFight.Count", "Użyj logiki WalkiDrużynowej gdy w pobliżu jest więcej przeciwników od {0}"},
                {"Common.Logic", "Common logic"},
                {"1vs1.Logic", "Logika 1vs1"},
                {"TeamFight.Logic", "Logika WalkiDrużynowej"},
                {"UseE.HealthPercent", "Użyj E gdy moje hp % zdrowia jest mniejsze od {0}"},
                {"UseE.Spells", "Użyj E na umiejętności przeciwnika"},
                {"Draw.Ball", "Pokaż pozycje kuli"},
                {"R.Block", "Blokuj R gdy nie trafi żadnego celu"},
                /* Drawings */
                {"Draw.Disable", "Wyłącz wszystkie rysowania"},
                {"Draw.DamageIndicator", "Pokaż wskaźnik obrażeń"},
                {"Draw.Target", "Pokaż krąg na celu"},
                {"Draw.Q", "Pokaż Q zasięg"},
                {"Draw.W", "Pokaż W zasięg"},
                {"Draw.E", "Pokaż E zasięg"},
                {"Draw.R", "Pokaż R zasięg"},
                {"Draw.Toggles", "Draw toggles status"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: SzansaNaTrafienie"},
                {"W.HitChancePercent", "W: SzansaNaTrafienie"},
                {"E.HitChancePercent", "E: SzansaNaTrafienie"},
                {"QE.HitChancePercent", "QE: SzansaNaTrafienie"},
                {"R.HitChancePercent", "R: SzansaNaTrafienie"}
            };
            Translations[Language.Chinese] = new Dictionary<string, string>
            {
                {"Language", "语言"},
                {"Chinese", "中文"},
                {"Enabled", "开启"},
                {"Disabled", "关闭"},
                {"Available", "可用的"},
                /* Keys */
                {"Combo.WithoutR", "不用R连招"},
                {"Harass.WEQ", "骚扰 2"},
                /* Toggles */
                {"LastHit.Toggle", "自动尾兵"},
                {"Harass.Toggle", "自动骚扰"},
                /* Submenus */
                {"Keys", "热键"},
                {"Prediction", "预判"},
                {"Combo", "连招"},
                {"Harass", "骚扰"},
                {"Clear", "清线"},
                {"LaneClear", "清线"},
                {"LastHit", "尾兵"},
                {"JungleClear", "清野"},
                {"KillSteal", "抢人头"},
                {"Automatic", "自动"},
                {"Evader", "躲避"},
                {"Drawings", "线圈"},
                {"Flee", "逃跑"},
                {"Misc", "杂项"},
                /* LastHit */
                {"Never", "从不"},
                {"Smartly", "中毒的"},
                {"Always", "一直"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "最低能量使用"},
                {"DisableUnderEnemyTurret", "在敌方塔下屏蔽"},
                {"IfKillable", "如果可击杀"},
                {"IfNeeded", "如果需要"},
                {"UseIgnite", "使用点燃抢头"},
                {"UseIgnite.Killable", "使用点燃如果可击杀"},
                {"UseSmite", "使用惩戒抢头"},
                {"UseQ", "使用 Q"},
                {"UseQ.Hit", "使用Q如果命中敌人数量 >= {0}"},
                {"UseQ.Gapcloser", "敌人切入时使用Q"},
                {"UseQ.Interrupter", "使用Q打断敌人技能"},
                {"UseW", "使用 W"},
                {"UseW.Hit", "使用W如果命中敌人数量 >= {0}"},
                {"UseW.Gapcloser", "敌人切入时使用W"},
                {"UseW.Interrupter", "使用W打断敌人技能"},
                {"UseE", "使用 E"},
                {"UseE.Hit", "使用E如果命中敌人数量 >= {0}"},
                {"UseE.Gapcloser", "敌人切入时使用E"},
                {"UseE.Interrupter", "使用E打断敌人技能"},
                {"UseR", "使用 R"},
                {"UseR.Killable", "当敌人可击杀使用R"},
                {"UseR.Hit", "使用R如果命中敌人数量 >= {0}"},
                {"UseR.Gapcloser", "敌人切入时使用R"},
                {"UseR.Interrupter", "使用R打断敌人技能"},
                {"R.BlackList", "对敌人不使用R"},
                {"Items", "使用物品"},
                {"Zhonyas", "自动中亚当生命值百分比低于 {0}"},
                /* Zed */
                {"R.Prevent", "R之前不使用技能"},
                {"R.Combo.Mode", "R 模式"},
                {"UseQ.Collision", "为Q检查施法路径 （更多伤害）"},
                {"UseW1", "使用 W1"},
                {"UseW2", "使用 W2"},
                {"UseR1", "使用 R1"},
                {"UseR2", "使用 R2"},
                {"SwapDead", "使用 W2/R2 如果可击杀敌人"},
                {"SwapGapclose", "使用 W2/R2 接近目标"},
                {"SwapKillable", "使用W2如果可击杀"},
                {"SwapHP", "使用 W2/R2 如果生命 >= {0}"},
                {"Line", "线性"},
                {"Triangle", "三角"},
                {"MousePos", "鼠标位置"},
                {"IsDead", "接受死亡吧"},
                {"Passive", "被动"},
                {"Draw.WShadow", "显示W线圈范围"},
                {"Draw.RShadow", "显示R线圈范围"},
                {"Draw.TargetIsDead", "显示目标可击杀提示"},
                {"Draw.PassiveIsReady", "显示主动技能冷却提示"},
                /* Cassiopeia */
                {"Poisoned", "中毒的"},
                {"AssistedUltimate", "大招辅助"},
                /* Diana */
                {"UseQR", "在小兵上使用QR进行间距"},
                {"R.2nd", "连招使用R2"},
                /* Orianna */
                {"TeamFight.Count", "使用团战逻辑当敌人数量 >= {0}"},
                {"Common.Logic", "普通逻辑"},
                {"1vs1.Logic", "1 vs 1 逻辑"},
                {"TeamFight.Logic", "团战逻辑"},
                {"UseE.HealthPercent", "使用E当生命低于 <= {0}"},
                {"UseE.Spells", "使用E抵挡敌方技能"},
                {"Draw.Ball", "显示球的位置"},
                {"R.Block", "屏蔽R如果会空大"},
                /* Drawings */
                {"Draw.Disable", "关闭线圈"},
                {"Draw.DamageIndicator", "敌方HP显示技能总伤害"},
                {"Draw.Target", "目标身上显示圈"},
                {"Draw.Q", "显示 Q 范围"},
                {"Draw.W", "显示 W 范围"},
                {"Draw.E", "显示 E 范围"},
                {"Draw.R", "显示 R 范围"},
                {"Draw.Toggles", "自动技能面板显示"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: 命中率百分比"},
                {"W.HitChancePercent", "W: 命中率百分比"},
                {"E.HitChancePercent", "E: 命中率百分比"},
                {"QE.HitChancePercent", "QE: 命中率百分比"},
                {"R.HitChancePercent", "R: 命中率百分比"}
            };
            Translations[Language.ChineseTraditional] = new Dictionary<string, string>
            {
                {"Language", "語言"},
                {"ChineseTraditional", "中文"},
                {"Enabled", "開啟"},
                {"Disabled", "關閉"},
                {"Available", "可用的"},
                /* Keys */
                {"Combo.WithoutR", "不用R連招"},
                {"Harass.WEQ", "騷擾 2"},
                /* Toggles */
                {"LastHit.Toggle", "自動尾兵"},
                {"Harass.Toggle", "自動騷擾"},
                /* Submenus */
                {"Keys", "熱鍵"},
                {"Prediction", "預判"},
                {"Combo", "連招"},
                {"Harass", "騷擾"},
                {"Clear", "清線"},
                {"LaneClear", "清線"},
                {"LastHit", "尾兵"},
                {"JungleClear", "清野"},
                {"KillSteal", "搶人頭"},
                {"Automatic", "自動"},
                {"Evader", "躲避"},
                {"Drawings", "線圈"},
                {"Flee", "逃跑"},
                {"Misc", "雜項"},
                /* LastHit */
                {"Never", "從不"},
                {"Smartly", "中毒的"},
                {"Always", "一直"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "最低能量使用"},
                {"DisableUnderEnemyTurret", "在敵方塔下遮罩"},
                {"IfKillable", "如果可擊殺"},
                {"IfNeeded", "如果需要d"},
                {"UseIgnite", "使用點燃搶頭"},
                {"UseIgnite.Killable", "使用點燃如果可擊殺"},
                {"UseSmite", "使用懲戒搶頭"},
                {"UseQ", "使用 Q"},
                {"UseQ.Hit", "使用Q如果命中敵人數量 >= {0}"},
                {"UseQ.Gapcloser", "敵人切入時使用Q"},
                {"UseQ.Interrupter", "使用Q打斷敵人技能"},
                {"UseW", "使用 W"},
                {"UseW.Hit", "使用W如果命中敵人數量 >= {0}"},
                {"UseW.Gapcloser", "敵人切入時使用W"},
                {"UseW.Interrupter", "使用W打斷敵人技能"},
                {"UseE", "使用 E"},
                {"UseE.Hit", "使用E如果命中敵人數量 >= {0}"},
                {"UseE.Gapcloser", "敵人切入時使用E"},
                {"UseE.Interrupter", "使用E打斷敵人技能"},
                {"UseR", "使用 R"},
                {"UseR.Killable", "當敵人可擊殺使用R"},
                {"UseR.Hit", "使用R如果命中敵人數量 >= {0}"},
                {"UseR.Gapcloser", "敵人切入時使用R"},
                {"UseR.Interrupter", "使用R打斷敵人技能"},
                {"R.BlackList", "對敵人不使用R"},
                {"Items", "使用物品"},
                {"Zhonyas", "自動中亞當生命值百分比低於 {0}"},
                /* Zed */
                {"R.Prevent", "R之前不使用技能"},
                {"R.Combo.Mode", "R 模式"},
                {"UseQ.Collision", "為Q檢查施法路徑 （更多傷害）"},
                {"UseW1", "使用 W1"},
                {"UseW2", "使用 W2"},
                {"UseR1", "使用 R1"},
                {"UseR2", "使用 R2"},
                {"SwapDead", "使用 W2/R2 如果可擊殺敵人"},
                {"SwapGapclose", "使用 W2/R2 接近目標"},
                {"SwapKillable", "使用W2如果可擊殺"},
                {"SwapHP", "使用 W2/R2 如果生命 >= {0}"},
                {"Line", "線性"},
                {"Triangle", "三角"},
                {"MousePos", "滑鼠位置"},
                {"IsDead", "接受死亡吧"},
                {"Passive", "被動"},
                {"Draw.WShadow", "顯示W線圈範圍"},
                {"Draw.RShadow", "顯示R線圈範圍"},
                {"Draw.TargetIsDead", "顯示目標可擊殺提示"},
                {"Draw.PassiveIsReady", "顯示主動技能冷卻提示"},
                /* Cassiopeia */
                {"Poisoned", "中毒的"},
                {"AssistedUltimate", "大招輔助"},
                /* Diana */
                {"UseQR", "在小兵上使用QR進行間距"},
                {"R.2nd", "連招使用R2"},
                /* Orianna */
                {"TeamFight.Count", "使用團戰邏輯當敵人數量 >= {0}"},
                {"Common.Logic", "普通邏輯"},
                {"1vs1.Logic", "1 vs 1 邏輯"},
                {"TeamFight.Logic", "團戰邏輯"},
                {"UseE.HealthPercent", "使用E當生命低於 <= {0}"},
                {"UseE.Spells", "使用E抵擋敵方技能"},
                {"Draw.Ball", "顯示球的位置"},
                {"R.Block", "遮罩R如果會空大"},
                /* Drawings */
                {"Draw.Disable", "關閉線圈"},
                {"Draw.DamageIndicator", "敵方HP顯示技能總傷害"},
                {"Draw.Target", "目標身上顯示圈"},
                {"Draw.Q", "顯示 Q 範圍"},
                {"Draw.W", "顯示 W 範圍"},
                {"Draw.E", "顯示 E 範圍"},
                {"Draw.R", "顯示 R 範圍"},
                {"Draw.Toggles", "自動技能面板顯示"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: 命中率百分比"},
                {"W.HitChancePercent", "W: 命中率百分比"},
                {"E.HitChancePercent", "E: 命中率百分比"},
                {"QE.HitChancePercent", "QE: 命中率百分比"},
                {"R.HitChancePercent", "R: 命中率百分比"}
            };
            Translations[Language.Portuguese] = new Dictionary<string, string>
            {
                {"Language", "Idioma"},
                {"Portuguese", "Português"},
                {"Enabled", "Habilitado"},
                {"Disabled", "Desabilitado"},
                {"Available", "Disponivel"},
                /* Keys */
                {"Combo.WithoutR", "Combo sem o R"},
                {"Harass.WEQ", "Harass WEQ"},
                /* Sempre ativo */
                {"LastHit.Toggle", "LastHit Sempre"},
                {"Harass.Toggle", "Harass Sempre"},
                /* Submenus */
                {"Keys", "Teclas"},
                {"Prediction", "Prediction"},
                {"Combo", "Combo"},
                {"Harass", "Harass"},
                {"Clear", "Clear"},
                {"LaneClear", "LaneClear"},
                {"LastHit", "LastHit"},
                {"JungleClear", "JungleClear"},
                {"KillSteal", "KillSteal"},
                {"Automatic", "Automatico"},
                {"Evader", "Evader"},
                {"Drawings", "Circulos/notificacoes"},
                {"Flee", "Fuga"},
                {"Misc", "Outros"},
                /* LastHit */
                {"Never", "Nunca"},
                {"Smartly", "Inteligente"},
                {"Always", "Sempre"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "Porcentagem minima de mana"},
                {"DisableUnderEnemyTurret", "Desabilitar debaixo da torre"},
                {"IfKillable", "Se der pra matar"},
                {"IfNeeded", "Se necessario"},
                {"UseIgnite", "Usar Ignite"},
                {"UseIgnite.Killable", "Usar Ignite se der pra matar"},
                {"UseSmite", "Usar Smite"},
                {"UseQ", "Usar o Q"},
                {"UseQ.Hit", "Usar o Q se o hit for maior que {0}"},
                {"UseQ.Gapcloser", "Usar o Q em gapcloses / dashes"},
                {"UseQ.Interrupter", "Usar o Q para interromper"},
                {"UseW", "Usar o W"},
                {"UseW.Hit", "Use o W se o hit for maior que {0}"},
                {"UseW.Gapcloser", "Usar o W em gapcloses / dashes"},
                {"UseW.Interrupter", "Usar o W para interromper"},
                {"UseE", "Usar o E"},
                {"UseE.Hit", "Use o E se o hit for maior que {0}"},
                {"UseE.Gapcloser", "Usar o E em gapcloses / dashes"},
                {"UseE.Interrupter", "Usar o E para interromper"},
                {"UseR", "Usar o R"},
                {"UseR.Killable", "Usar o R se der pra matar"},
                {"UseR.Hit", "Usar o R se o hit for maior que {0}"},
                {"UseR.Gapcloser", "Usar o R em gapcloses / dahes"},
                {"UseR.Interrupter", "Usar o R para interromper"},
                {"R.BlackList", "Nao usar o R em:"},
                {"Items", "Usar items ofensivos"},
                {"Zhonyas", "Usar Zhonyas se minha vida for menor que % {0}"},
                /* Zed */
                {"R.Prevent", "Não usar spells antes do R"},
                {"R.Combo.Mode", "R Modo do combo"},
                {"UseQ.Collision", "Checar collisao antes de usar o Q (mais dano)"},
                {"UseW1", "Usar W1"},
                {"UseW2", "Usar W2"},
                {"UseR1", "Usar R1"},
                {"UseR2", "Uare R2"},
                {"SwapDead", "Usar W2/R2 se o alvo for morrer"},
                {"SwapGapclose", "Usar o W2/R2 para chegar perto do alvo"},
                {"SwapKillable", "Usar o W2 se der pra matar"},
                {"SwapHP", "Usar W2/R2 se a minha % de vida for menor que {0}"},
                {"Line", "Linha"},
                {"Triangle", "Triangulo"},
                {"MousePos", "Posicao do Mouse"},
                {"IsDead", "Se fodeu"},
                {"Passive", "Passiva"},
                {"Draw.WShadow", "Destacar a sombra do W"},
                {"Draw.RShadow", "Destacar a sombra do R"},
                {"Draw.TargetIsDead", "Mostrar texto quando alvo for morrer"},
                {"Draw.PassiveIsReady", "Mostrar texto quando a passive estiver disponivel"},
                /* Cassiopeia */
                {"Poisoned", "Se estiver com veneno"},
                {"AssistedUltimate", "Ajuda com a Ult"},
                /* Diana */
                {"UseQR", "Usar QR em minions para chegar perto"},
                {"R.2nd", "Sempre usar o segundo R"},
                /* Orianna */
                {"TeamFight.Count", "Usar logica de teamfight se o numero de inimigos for maior que {0}"},
                {"Common.Logic", "Logica Normal"},
                {"1vs1.Logic", "Logica de x1"},
                {"TeamFight.Logic", "Logica de TeamFight"},
                {"UseE.HealthPercent", "Usar o E se minha % de vida for menor que {0}"},
                {"UseE.Spells", "Usar o E em Skills inimigas"},
                {"Draw.Ball", "Mostrar a posição da bola"},
                {"R.Block", "Bloquear o R se não for acertar"},
                /* Drawings */
                {"Draw.Disable", "Desabilitar todos os circulos"},
                {"Draw.DamageIndicator", "Mostrar indicador de dano"},
                {"Draw.Target", "Destacar Alvo"},
                {"Draw.Q", "Mostrar range do Q"},
                {"Draw.W", "Mostrar range do W"},
                {"Draw.E", "Mostrar range do E"},
                {"Draw.R", "Mostrar range do R"},
                {"Draw.Toggles", "Destacar o status de \"sempre ativo\""},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: Porcentagem de chance de acerto"},
                {"W.HitChancePercent", "W: Porcentagem de chance de acerto"},
                {"E.HitChancePercent", "E: Porcentagem de chance de acerto"},
                {"QE.HitChancePercent", "QE: Porcentagem de chance de acerto"},
                {"R.HitChancePercent", "R: Porcentagem de chance de acerto"}
            };
            Translations[Language.Italian] = new Dictionary<string, string>
            {
                {"Language", "Language"},
                {"Italian", "Italian"},
                {"Enabled", "Enabled"},
                {"Disabled", "Disabled"},
                {"Available", "Available"},
                /* Keys */
                {"Combo.WithoutR", "Combo without R"},
                {"Harass.WEQ", "Harass WEQ"},
                /* Toggles */
                {"LastHit.Toggle", "LastHit Toggle"},
                {"Harass.Toggle", "Harass Toggle"},
                /* Submenus */
                {"Keys", "Keys"},
                {"Prediction", "Prediction"},
                {"Combo", "Combo"},
                {"Harass", "Harass"},
                {"Clear", "Clear"},
                {"LaneClear", "LaneClear"},
                {"LastHit", "LastHit"},
                {"JungleClear", "JungleClear"},
                {"KillSteal", "KillSteal"},
                {"Automatic", "Automatic"},
                {"Evader", "Evader"},
                {"Drawings", "Drawings"},
                {"Flee", "Flee"},
                {"Misc", "Misc"},
                /* LastHit */
                {"Never", "Never"},
                {"Smartly", "Smartly"},
                {"Always", "Always"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "Minimum Mana Percent"},
                {"DisableUnderEnemyTurret", "Disable under enemy turret"},
                {"IfKillable", "If killable"},
                {"IfNeeded", "If needed"},
                {"UseIgnite", "Use Ignite"},
                {"UseIgnite.Killable", "Use Ignite if target is killable"},
                {"UseSmite", "Use Smite"},
                {"UseQ", "Use Q"},
                {"UseQ.Hit", "Use Q if hit is greater than {0}"},
                {"UseQ.Gapcloser", "Use Q on hero gapclosing / dashing"},
                {"UseQ.Interrupter", "Use Q on channeling spells"},
                {"UseW", "Use W"},
                {"UseW.Hit", "Use W if hit is greater than {0}"},
                {"UseW.Gapcloser", "Use W on hero gapclosing / dashing"},
                {"UseW.Interrupter", "Use W on channeling spells"},
                {"UseE", "Use E"},
                {"UseE.Hit", "Use E if hit is greater than {0}"},
                {"UseE.Gapcloser", "Use E on hero gapclosing / dashing"},
                {"UseE.Interrupter", "Use E on channeling spells"},
                {"UseR", "Use R"},
                {"UseR.Killable", "Use R if target is killable"},
                {"UseR.Hit", "Use R if hit is greater than {0}"},
                {"UseR.Gapcloser", "Use R on hero gapclosing / dashing"},
                {"UseR.Interrupter", "Use R on channeling spells"},
                {"R.BlackList", "Don't use R on:"},
                {"Items", "Use offensive items"},
                {"Zhonyas", "Use Zhonyas if my % of health is less than {0}"},
                /* Zed */
                {"R.Prevent", "Don't use spells before R"},
                {"R.Combo.Mode", "R Combo Mode"},
                {"UseQ.Collision", "Check collision when casting Q (more damage)"},
                {"UseW1", "Use W1"},
                {"UseW2", "Use W2"},
                {"UseR1", "Use R1"},
                {"UseR2", "Use R2"},
                {"SwapDead", "Use W2/R2 if target will die"},
                {"SwapGapclose", "Use W2/R2 to get close to target"},
                {"SwapKillable", "Use W2 if target is killable"},
                {"SwapHP", "Use W2/R2 if my % of health is less than {0}"},
                {"Line", "Line"},
                {"Triangle", "Triangle"},
                {"MousePos", "MousePos"},
                {"IsDead", "Is Dead"},
                {"Passive", "Passive"},
                {"Draw.WShadow", "Draw W shadow circle"},
                {"Draw.RShadow", "Draw R shadow circle"},
                {"Draw.TargetIsDead", "Draw text if target will die"},
                {"Draw.PassiveIsReady", "Draw text when passive is available"},
                /* Cassiopeia */
                {"Poisoned", "If Poisoned"},
                {"AssistedUltimate", "Assisted Ultimate"},
                /* Diana */
                {"UseQR", "Use QR on minion to gapclose"},
                {"R.2nd", "Use always second r"},
                /* Orianna */
                {"TeamFight.Count", "Use TeamFight logic if enemies near is greater than {0}"},
                {"Common.Logic", "Common logic"},
                {"1vs1.Logic", "1 vs 1 logic"},
                {"TeamFight.Logic", "TeamFight logic"},
                {"UseE.HealthPercent", "Use E if my % of health is less than {0}"},
                {"UseE.Spells", "Use E on enemy spells"},
                {"Draw.Ball", "Draw ball position"},
                {"R.Block", "Block R if will not hit"},
                /* Drawings */
                {"Draw.Disable", "Disable all drawings"},
                {"Draw.DamageIndicator", "Draw damage indicator"},
                {"Draw.Target", "Draw circle on target"},
                {"Draw.Q", "Draw Q range"},
                {"Draw.W", "Draw W range"},
                {"Draw.E", "Draw E range"},
                {"Draw.R", "Draw R range"},
                {"Draw.Toggles", "Draw toggles status"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: HitChancePercent"},
                {"W.HitChancePercent", "W: HitChancePercent"},
                {"E.HitChancePercent", "E: HitChancePercent"},
                {"QE.HitChancePercent", "QE: HitChancePercent"},
                {"R.HitChancePercent", "R: HitChancePercent"}
            };
            Translations[Language.Turkish] = new Dictionary<string, string>
            {
                {"Language", "Dil"},
                {"Turkish", "Türkçe"},
                {"Enabled", "Etkin"},
                {"Disabled", "Etkin Değil"},
                {"Available", "Kullanılabilir"},
                /* Keys */
                {"Combo.WithoutR", "R'siz kombo"},
                {"Harass.WEQ", "WEQ ile dürtme"},
                /* Toggles */
                {"LastHit.Toggle", "Son vuruş (aç/kapa)"},
                {"Harass.Toggle", "Dürtme (aç/kapa)"},
                /* Submenus */
                {"Keys", "Düğmeler"},
                {"Prediction", "Tutturma"},
                {"Combo", "Kombo"},
                {"Harass", "Dürtme"},
                {"Clear", "Temizleme"},
                {"LaneClear", "MinyonTemizleme"},
                {"LastHit", "SonVuruş"},
                {"JungleClear", "OrmanTemizleme"},
                {"KillSteal", "KillÇalma"},
                {"Automatic", "Otomatik"},
                {"Evader", "Dodgelama"},
                {"Drawings", "Çizimler"},
                {"Flee", "Kaçış"},
                {"Misc", "Çeşitli"},
                /* LastHit */
                {"Never", "Asla"},
                {"Smartly", "Akıllıca"},
                {"Always", "Hep"},
                /* Checkbox, sliders and others */
                {"MinimumManaPercent", "Minimum Mana Yüzdesi"},
                {"DisableUnderEnemyTurret", "Düşman kulesinin altında devre dışı bırak"},
                {"IfKillable", "Öldürülebilir ise"},
                {"IfNeeded", "Gerekirse"},
                {"UseIgnite", "Tutuştur kullan"},
                {"UseIgnite.Killable", "Hedef öldürülebilir ise tutuştur kullan"},
                {"UseSmite", "Çarp kullan"},
                {"UseQ", "Q kullan"},
                {"UseQ.Hit", "Hasar {0} dan büyükse Q kullan"},
                {"UseQ.Gapcloser", "Yaklaşma/atılma yapan rakibe Q kullan"},
                {"UseQ.Interrupter", "Odaklanılan yeteneklere Q kullan"},
                {"UseW", "W kullan"},
                {"UseW.Hit", "Hasar {0} dan büyükse W kullan"},
                {"UseW.Gapcloser", "Yaklaşma/atılma yapan rakibe W kullan"},
                {"UseW.Interrupter", "Odaklanılan yeteneklere W kullan"},
                {"UseE", "E kullan"},
                {"UseE.Hit", "Hasar {0} dan büyükse E kullan"},
                {"UseE.Gapcloser", "Yaklaşma/atılma yapan rakibe E kullan"},
                {"UseE.Interrupter", "Odaklanılan yeteneklere E kullan"},
                {"UseR", "R kullan"},
                {"UseR.Killable", "Hedef öldürülebilir ise R kullan"},
                {"UseR.Hit", "Hasar {0} dan büyükse R kullan"},
                {"UseR.Gapcloser", "Yaklaşma/atılma yapan rakibe R kullan"},
                {"UseR.Interrupter", "Odaklanılan yeteneklere R kullan"},
                {"R.BlackList", "İşaretlenenlere R kullanma:"},
                {"Items", "Saldırı amaçlı eşyaları kullan"},
                {"Zhonyas", "Canım % {0} dan azsa Zhonya bas"},
                /* Zed */
                {"R.Prevent", "R'den önce yetenek kullanma"},
                {"R.Combo.Mode", "R Kombo Modu"},
                {"UseQ.Collision", "Q atmadan önce kolüzyona dikkat et (daha çok hasar)"},
                {"UseW1", "W1 kullan (Gölge at)"},
                {"UseW2", "W2 kullan (Gölgeyle yer değiş)"},
                {"UseR1", "R1 kullan (Ulti at)"},
                {"UseR2", "R2 kullan (Gölgeyle yer değiş)"},
                {"SwapDead", "Hedef ölecekse gölgelerin biriyle yer değiştir"},
                {"SwapGapclose", "Gölgelerle yer değiştirerek hedefe yaklaş"},
                {"SwapKillable", "Hedef öldürülebilirse gölgeyle yaklaş"},
                {"SwapHP", "Canım % {0} dan azsa gölgeyle yer değiştir"},
                {"Line", "Çizgi"},
                {"Triangle", "Üçgen"},
                {"MousePos", "FareKonumu"},
                {"IsDead", "Öldü"},
                {"Passive", "Pasif"},
                {"Draw.WShadow", "W gölgesine daire koy"},
                {"Draw.RShadow", "R gölgesine daire koy"},
                {"Draw.TargetIsDead", "Hedef ölecekse 'öldü' yaz"},
                {"Draw.PassiveIsReady", "Pasif hedefte çalışabilecekse 'Pasif' yaz"},
                /* Cassiopeia */
                {"Poisoned", "Zehirlenmiş ise"},
                {"AssistedUltimate", "Ulti yardımcısı"},
                /* Diana */
                {"UseQR", "Hedefe yaklaşmak için minyona QR kullan"},
                {"R.2nd", "Her zaman ikinci R'yi kullan"},
                /* Orianna */
                {"TeamFight.Count", "Yakında {0} dan fazla rakip varsa Takım Savaşı Mantığını kullan"},
                {"Common.Logic", "Genel Mantık"},
                {"1vs1.Logic", "1 vs 1 mantığı"},
                {"TeamFight.Logic", "Takım Savaşı Mantığı"},
                {"UseE.HealthPercent", "Canım % {0} den azsa E kullan"},
                {"UseE.Spells", "Rakip yeteneklerine karşı E kullan"},
                {"Draw.Ball", "Topun konumunu çiz"},
                {"R.Block", "Kimseye çarpmayacaksa R'yi engelle"},
                /* Drawings */
                {"Draw.Disable", "Bütün çizimleri devre dışı bırak"},
                {"Draw.DamageIndicator", "Hedefe verilebilecek hasarı çiz"},
                {"Draw.Target", "Hedefin altına daire çiz"},
                {"Draw.Q", "Q menzilini çiz"},
                {"Draw.W", "W menzilini çiz"},
                {"Draw.E", "E menzilini çiz"},
                {"Draw.R", "R menzilini çiz"},
                {"Draw.Toggles", "Aç/kapa özelliklerinin durumunu yaz"},
                /* Prediction*/
                {"Q.HitChancePercent", "Q: VurmaŞansıYüzdesi"},
                {"W.HitChancePercent", "W: VurmaŞansıYüzdesi"},
                {"E.HitChancePercent", "E: VurmaŞansıYüzdesi"},
                {"QE.HitChancePercent", "QE: VurmaŞansıYüzdesi"},
                {"R.HitChancePercent", "R: VurmaŞansıYüzdesi"}
            };

        }

        public static Language CurrentLanguage
        {
            get { return (Language)MenuManager.Menu["Language"].Cast<Slider>().CurrentValue; }
        }

        public static Language CurrentCulture
        {
            get
            {
                if (CulturesToLanguage.ContainsKey(CultureInfo.InstalledUICulture.ToString()))
                {
                    return CulturesToLanguage[CultureInfo.InstalledUICulture.ToString()];
                }
                return Language.English;
            }
        }

        public static void Initialize()
        {
            MenuManager.Translate(Language.English, (Language)MenuManager.Menu["Language"].Cast<Slider>().CurrentValue);
        }

        public static string GetTranslationFromId(this string name)
        {
            if (Translations.ContainsKey(CurrentLanguage) && Translations[CurrentLanguage].ContainsKey(name))
            {
                return Translations[CurrentLanguage][name];
            }
            if (Translations.ContainsKey(Language.English))
            {
                if (Translations[Language.English].ContainsKey(name))
                {
                    return Translations[Language.English][name];
                }
            }
            return name;
        }

        public static string GetTranslationFromDisplayName(Language from, Language to, string displayName)
        {
            if (from != to)
            {
                if (Translations.ContainsKey(from))
                {
                    foreach (var pair in from pair in Translations[@from]
                                         where pair.Value == displayName
                                         where Translations.ContainsKey(to)
                                         where Translations[to].ContainsKey(pair.Key)
                                         select pair)
                    {
                        return Translations[to][pair.Key];
                    }
                }
                if (Translations.ContainsKey(Language.English))
                {
                    return (from pair in Translations[Language.English]
                            where pair.Value == displayName
                            where Translations.ContainsKey(to)
                            where Translations[to].ContainsKey(pair.Key)
                            select Translations[to][pair.Key]).FirstOrDefault();
                }
            }
            return null;
        }
    }
}