using System;
using System.Runtime.InteropServices;

namespace KontoCheckRestApi
{
    /// <summary>
    /// See: mini1.cs of konto_check
    /// </summary>
    public class KontoCheckLibraryImport
    {
        #region Externals

        /* In diesem Teil sind nur die DLL-Einsprungpunkte definiert. Eine
         * kurze Beschreibung der einzelnen Funktionen findet sich unten bei
         * der Definition der einzelnen Funktionen.
         */

        /* Allgemeine Funktionen +§§§3 */
        #region Allgemeine Funktionen
        /* Entrypoint konto_check_idx2blz +§§§4 */
        [DllImport("konto_check", EntryPoint = "konto_check_idx2blz")]
        private static extern Int32 konto_check_idx2blz(Int32 idx, out Int32 zweigstelle, out Int32 retval);

        /* Entrypoint kto_check_encoding +§§§4 */
        [DllImport("konto_check", EntryPoint = "kto_check_encoding")]
        private static extern Int32 kto_check_encoding_i(Int32 encoding);

        /* Entrypoint kto_check_init_p +§§§4 */
        [DllImport("konto_check", EntryPoint = "kto_check_init_p")]
        private static extern Int32 kto_check_init_i(String lutName, Int32 required, Int32 set, Int32 incremental);

        /* Entrypoint current_lutfile_name +§§§4 */
        [DllImport("konto_check", EntryPoint = "current_lutfile_name")]
        private static extern IntPtr current_lutfile_name_i(out Int32 set, out Int32 level, out Int32 retval);

        /* Entrypoint kto_check_blz +§§§4 */
        [DllImport("konto_check", EntryPoint = "kto_check_blz")]
        private static extern Int32 kto_check_blz(String blz, String kto);

        /* Entrypoint kto_check_retval2txt +§§§4 */
        [DllImport("konto_check", EntryPoint = "kto_check_retval2txt", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr kto_check_retval2txt(Int32 retval);

        /* Entrypoint kto_check_retval2txt_short +§§§4 */
        [DllImport("konto_check", EntryPoint = "kto_check_retval2txt_short", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr kto_check_retval2txt_short(Int32 retval);

        /* Entrypoint cleanup_kto +§§§4 */
        [DllImport("konto_check", EntryPoint = "cleanup_kto", CallingConvention = CallingConvention.Cdecl)]
        private static extern void cleanup_kto();

        /* Entrypoint kc_alloc +§§§4 */
        [DllImport("konto_check", EntryPoint = "kc_alloc", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr kc_alloc(Int32 size, out Int32 retval);

        /* Entrypoint kc_free +§§§4 */
        [DllImport("konto_check", EntryPoint = "kc_free", CallingConvention = CallingConvention.Cdecl)]
        private static extern void kc_free(IntPtr ptr);

        /* IBAN-Funktionen +§§§3 */
        /* Entrypoint iban2bic +§§§4 */
        [DllImport("konto_check", EntryPoint = "iban2bic", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr iban2bic_i(String iban, out Int32 retval, IntPtr blz, IntPtr kto);

        /* Entrypoint iban_gen +§§§4 */
        [DllImport("konto_check", EntryPoint = "iban_gen", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr iban_gen_i(String blz, String kto, out Int32 retval);

        /* Entrypoint iban_check +§§§4 */
        [DllImport("konto_check", EntryPoint = "iban_check", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 iban_check_i(String iban, out Int32 retval);

        /* Entrypoint ipi_gen +§§§4 */
        [DllImport("konto_check", EntryPoint = "ipi_gen", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 ipi_gen_i(String zweck, out IntPtr dst, out IntPtr papier);

        /* Entrypoint ipi_check +§§§4 */
        [DllImport("konto_check", EntryPoint = "ipi_check", CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 ipi_check(String ipi);
        #endregion

        /* Suchfunktionen +§§§3 */
        #region Suchfunktionen
        /* Entrypoint lut_suche_bic +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_suche_bic")]
        private static extern Int32 lut_suche_bic(String such_name, out Int32 anzahl, out IntPtr start_idx,
                 out IntPtr zweigstellen, out IntPtr base_name, out IntPtr blz_base);

        /* Entrypoint lut_suche_namen +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_suche_namen")]
        private static extern Int32 lut_suche_namen(String such_name, out Int32 anzahl, out IntPtr start_idx,
                 out IntPtr zweigstellen, out IntPtr base_name, out IntPtr blz_base);

        /* Entrypoint lut_suche_namen_kurz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_suche_namen_kurz")]
        private static extern Int32 lut_suche_namen_kurz(String such_name, out Int32 anzahl, out IntPtr start_idx,
                 out IntPtr zweigstellen, out IntPtr base_name, out IntPtr blz_base);

        /* Entrypoint lut_suche_ort +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_suche_ort")]
        private static extern Int32 lut_suche_ort(String such_name, out Int32 anzahl, out IntPtr start_idx,
                 out IntPtr zweigstellen, out IntPtr base_name, out IntPtr blz_base);

        /* Entrypoint lut_suche_plz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_suche_plz")]
        private static extern Int32 lut_suche_plz(Int32 such1, Int32 such2, out Int32 anzahl, out IntPtr start_idx,
                 out IntPtr zweigstellen, out IntPtr base_name, out IntPtr blz_base);

        /* Entrypoint lut_suche_blz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_suche_blz")]
        private static extern Int32 lut_suche_blz(Int32 such1, Int32 such2, out Int32 anzahl, out IntPtr start_idx,
                 out IntPtr zweigstellen, out IntPtr base_name, out IntPtr blz_base);

        /* Entrypoint lut_suche_pz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_suche_pz")]
        private static extern Int32 lut_suche_pz(Int32 such1, Int32 such2, out Int32 anzahl, out IntPtr start_idx,
                 out IntPtr zweigstellen, out IntPtr base_name, out IntPtr blz_base);

        #endregion

        /* Funktionen für die LUT-datei +§§§3 */
        #region Funktionen für die LUT-datei
        /* Entrypoint generate_lut2_p +§§§4 */
        [DllImport("konto_check", EntryPoint = "generate_lut2_p")]
        private static extern Int32 generate_lut2_p(String inputname, String outputname, String user_info,
                 String gueltigkeit, Int32 felder, Int32 filialen, Int32 slots, Int32 lut_version, Int32 set);

        /* Entrypoint lut_keine_iban_berechnung +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_keine_iban_berechnung")]
        private static extern Int32 lut_keine_iban_berechnung_i(String iban_blacklist, String lutfile, Int32 set);

        /* Entrypoint lut_dir_dump_str +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_dir_dump_str")]
        private static extern Int32 lut_dir_dump_str_i(String lutname, out IntPtr dptr);

        /* Entrypoint lut_info +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_info")]
        private static extern Int32 lut_info_i(String lutname, out IntPtr info1, out IntPtr info2, out Int32 valid1, out Int32 valid2);

        /* Entrypoint lut_blz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_blz")]
        private static extern Int32 lut_blz(String blz, Int32 zweigstelle);

        /* Entrypoint lut_filialen +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_filialen")]
        private static extern Int32 lut_filialen(String blz, out Int32 retval);

        /* Entrypoint lut_name +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_name")]
        private static extern IntPtr lut_name(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_name_kurz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_name_kurz")]
        private static extern IntPtr lut_name_kurz(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_plz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_plz")]
        private static extern Int32 lut_plz(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_ort +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_ort")]
        private static extern IntPtr lut_ort(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_pan +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_pan")]
        private static extern Int32 lut_pan(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_bic +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_bic")]
        private static extern IntPtr lut_bic(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_nr +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_nr")]
        private static extern Int32 lut_nr(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_pz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_pz")]
        private static extern Int32 lut_pz(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_aenderung +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_aenderung")]
        private static extern Int32 lut_aenderung(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_loeschung +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_loeschung")]
        private static extern Int32 lut_loeschung(String blz, Int32 zweigstelle, out Int32 retval);

        /* Entrypoint lut_nachfolge_blz +§§§4 */
        [DllImport("konto_check", EntryPoint = "lut_nachfolge_blz")]
        private static extern Int32 lut_nachfolge_blz(String blz, Int32 zweigstelle, out Int32 retval);

        #endregion
        #endregion

        #region kc_defs
        /* C#-Definitionen: Allgemeine Funktionen +§§§2 */
        #region allgemeine Funktionen
        /* Funktion kto_check_init() +§§§3 */
        #region kto_check_init()
        /* Die Funktion kto_check_init() initialisiert die Bibliothek mit den
         * Werten aus einer LUT-Datei. Die Parameter sind alle optional, da in
         * der konto_check Bibliothek viele Defaultwerte vorgegeben sind, die
         * normalerweise ausreichen. Die Parameter haben die folgende Bedeutung:
         *
         * lutfile:      Die Datei aus der gelesen werden soll. Defaultwerte
         *               sind dabei für den Dateipfad (in dieser Reihenfolge)
         *               ".","C:","C:\\Programme\\konto_check"
         *               und für den Dateinamen "blz.lut","blz.lut2f","blz.lut2".
         *               Die Werte können in der Datei konto_check.h beliebig
         *               verändert werden.
         *
         * required:     (Integerwert zwischen 0 und 9). Gibt an, welche BLocks
         *               geladen werden sollen; Default ist 7. Eine Liste der
         *               geladenen Blocks findet sich im Anhang der Datei
         *               00liesmich.pdf.
         *
         * set:          (Integer, 0, 1 oder 2). In einer LUT-Datei können zwei
         *               Datensätze enthalten sein; dieser Parameter bestimmt,
         *               welcher Satz zu laden ist. Bei 0 wird der Datensatz
         *               anhand des Systemdatums und Gültigkeitszeitraums der
         *               beiden Datensätze automatisch bestimmt.
         *
         * incremental: falls der Parameter 1 ist, wird eine inkrementelle
         *              Initialisierung (Nachladen von noch nicht geladenen
         *              Blocks) versucht. Diese ist allerdings nur vom selben
         *              Datensatz wie bei der initialen Initialisierung
         *              möglich.
         */

        /* Funktion kto_check_init() +§§§4 */
        public static Int32 kto_check_init()
        {
            return kto_check_init_i("konto_check/blz.lut", 7, 0, 0); // Note: original does not set the lut file path here
        }
        /* Funktion kto_check_init(String lutfile) +§§§4 */
        static Int32 kto_check_init(String lutfile)
        {
            return kto_check_init_i(lutfile, 7, 0, 0);
        }
        /* Funktion kto_check_init(String lutfile, Int32 level) +§§§4 */
        static Int32 kto_check_init(String lutfile, Int32 level)
        {
            return kto_check_init_i(lutfile, level, 0, 0);
        }
        /* Funktion kto_check_init(String lutfile, Int32 level, Int32 set) +§§§4 */
        static Int32 kto_check_init(String lutfile, Int32 level, Int32 set)
        {
            return kto_check_init_i(lutfile, level, set, 0);
        }
        /* Funktion kto_check_init(String lutfile, Int32 level, Int32 set, Int32 incremental) +§§§4 */
        static Int32 kto_check_init(String lutfile, Int32 level, Int32 set, Int32 incremental)
        {
            return kto_check_init_i(lutfile, level, set, incremental);
        }
        #endregion

        /* Funktion kto_check_encoding() +§§§3 */
        #region kto_check_encoding()
        /* Die Funktion kto_check_encoding() setzt (bzw. liest) die Kodierung
         * für die konto_check Bibliothek. Es kann sowohl die Kodierung für
         * die Fehlermeldungen als auch die der LUT-Datei gesetzt werden.
         * Innerhalb der LUT-Datei sind die Werte im Format ISO-8859-1
         * gespeichert; sie werden bei der Initialisierung konvertiert.
         *
         * Für den Parameter mode werden die folgenden Werte akzeptiert:
         *       1: ISO-8859-1
         *       2: UTF-8
         *       3: HTML-Entities
         *       4: DOS (CP850)
         *      51: Fehlermeldungen als Makronamen, Rest in ISO-8859-1
         *      52: Fehlermeldungen als Makronamen, Rest in UTF-8
         *      53: Fehlermeldungen als Makronamen, Rest in HTML-Entities
         *      54: Fehlermeldungen als Makronamen, Rest in DOS (CP850)
         *
         * Rückgabewert ist der aktuell gesetzte Modus (als Zahl). Falls die
         * Funktion mit dem Parameter 0 aufgerufen wird, wird nur die aktuelle
         * Kodierung zurückgegeben.
         */

        /* Funktion kto_check_encoding() +§§§4 */
        static Int32 kto_check_encoding()
        {
            return kto_check_encoding_i(0);
        }
        /* Funktion kto_check_encoding(Int32 encoding) +§§§4 */
        static Int32 kto_check_encoding(Int32 encoding)
        {
            return kto_check_encoding_i(encoding);
        }
        #endregion

        /* Funktion current_lutfile_name() +§§§3 */
        #region current_lutfile_name()
        /* Die Funktion liefert den Namen der LUT-Datei von der initialisiert
         * wurde, sowie das benutzte Set und den Initialisierungslevel zurück.
         * Die Parameter haben die folgende Bedeutung:
         *
         * set:          Das benutzte Set (1 oder 2), oder 0 falls noch nicht
         *               initialisiert wurde.
         *
         * level:        Der Initialisierungslevel (0...9).
         *
         * retval:       Statuswert; er kann die Werte -40 (noch nicht
         *               initialisiert) oder 1 (OK) annehmen:
         *
         * Der Rückgabewert ist der Name der LUT-Datei, von der initialisiert
         * wurde.
         */
        /* Funktion current_lutfile_name() +§§§4 */
        static String current_lutfile_name()
        {
            Int32 set, level, retval;

            return Marshal.PtrToStringAnsi(current_lutfile_name_i(out set, out level, out retval));
        }
        /* Funktion current_lutfile_name(out Int32 set) +§§§4 */
        static String current_lutfile_name(out Int32 set)
        {
            Int32 level, retval;

            return Marshal.PtrToStringAnsi(current_lutfile_name_i(out set, out level, out retval));
        }
        /* Funktion current_lutfile_name(out Int32 set,out Int32 level) +§§§4 */
        static String current_lutfile_name(out Int32 set, out Int32 level)
        {
            Int32 retval;

            return Marshal.PtrToStringAnsi(current_lutfile_name_i(out set, out level, out retval));
        }
        /* Funktion current_lutfile_name(out Int32 set,out Int32 level,out Int32 retval) +§§§4 */
        static String current_lutfile_name(out Int32 set, out Int32 level, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(current_lutfile_name_i(out set, out level, out retval));
        }
        #endregion

        /* Funktion retval2txt() +§§§3 */
        #region retval2txt()

        /* ###########################################################################
         * # Die Funktion kto_check_retval2txt() wandelt die numerischen Rückgabe-   #
         * # werte in Klartext um. Die Funktion retval2txt_short macht dasselbe,     #
         * # nur mit symbolischen Klartexten (Makronamen).                           #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion retval2txt(Int32 retval) +§§§4 */
        public static String retval2txt(Int32 retval)
        {
            return Marshal.PtrToStringAnsi(kto_check_retval2txt(retval));
        }

        /* Funktion retval2txt_short(Int32 retval) +§§§4 */
        static String retval2txt_short(Int32 retval)
        {
            return Marshal.PtrToStringAnsi(kto_check_retval2txt_short(retval));
        }
        #endregion
        #region kto_check_free()

        /* ###########################################################################
         * # Die Funktion kto_check_free() gibt allen benutzten Speicher der         #
         * # konto_check Bibliothek wieder frei.                                     #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion kto_check_free() +§§§4 */
        static void kto_check_free()
        {
            cleanup_kto();
        }
        #endregion
        #endregion

        /* C#-Definitionen: IBAN-Funktionen +§§§2 */
        #region IBAN-Funktionen
        /* Funktion iban2bic() +§§§3 */
        #region iban2bic()

        /* ###########################################################################
         * # Die Funktion iban2bic extrahiert aus einer IBAN (International Bank     #
         * # Account Number) Kontonummer und Bankleitzahl, und bestimmt zu der BLZ   #
         * # die zugehörige BIC. Voraussetzung ist natürlich, daß das BIC Feld in    #
         * # der geladenen LUT-Datei enthalten ist. BLZ und Kontonummer werden,      #
         * # falls gewünscht, in zwei Variablen zurückgegeben.                       #
         * #                                                                         #
         * # Die Funktion arbeitet nur für deutsche Banken, da für andere keine      #
         * # Infos vorliegen.                                                        #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion iban2bic(String iban) +§§§4 */
        public static String iban2bic(String iban)
        {
            Int32 rv;
            IntPtr blz_p, kto_p;
            String bic;

            blz_p = kc_alloc(10, out rv);
            kto_p = kc_alloc(16, out rv);
            bic = Marshal.PtrToStringAnsi(iban2bic_i(iban, out rv, blz_p, kto_p));
            kc_free(blz_p);
            kc_free(kto_p);
            return bic;
        }
        /* Funktion iban2bic(String iban,out Int32 retval) +§§§4 */
        static String iban2bic(String iban, out Int32 retval)
        {
            Int32 rv;
            IntPtr blz_p, kto_p;
            String bic;

            blz_p = kc_alloc(10, out rv);
            kto_p = kc_alloc(16, out rv);
            bic = Marshal.PtrToStringAnsi(iban2bic_i(iban, out retval, blz_p, kto_p));
            kc_free(blz_p);
            kc_free(kto_p);
            return bic;
        }
        /* Funktion iban2bic(String iban,out String blz, out String kto) +§§§4 */
        static String iban2bic(String iban, out String blz, out String kto)
        {
            Int32 rv;
            IntPtr blz_p, kto_p;
            String bic;

            blz_p = kc_alloc(10, out rv);
            kto_p = kc_alloc(16, out rv);
            bic = Marshal.PtrToStringAnsi(iban2bic_i(iban, out rv, blz_p, kto_p));
            blz = Marshal.PtrToStringAnsi(blz_p);
            kto = Marshal.PtrToStringAnsi(kto_p);
            kc_free(blz_p);
            kc_free(kto_p);
            return bic;
        }
        /* Funktion iban2bic(String iban,out String blz, out String kto,out Int32 retval) +§§§4 */
        public static String iban2bic(String iban, out String blz, out String kto, out Int32 retval)
        {
            Int32 rv;
            IntPtr blz_p, kto_p;
            String bic;

            blz_p = kc_alloc(10, out rv);
            kto_p = kc_alloc(16, out rv);
            bic = Marshal.PtrToStringAnsi(iban2bic_i(iban, out retval, blz_p, kto_p));
            blz = Marshal.PtrToStringAnsi(blz_p);
            kto = Marshal.PtrToStringAnsi(kto_p);
            kc_free(blz_p);
            kc_free(kto_p);
            return bic;
        }
        #endregion

        /* Funktion iban_gen() +§§§3 */
        #region iban_gen()
        /* Funktion iban_gen(String blz, String kto) +§§§4 */
        public static String iban_gen(String blz, String kto)
        {
            Int32 retval;
            IntPtr iban_p;
            String iban;

            iban_p = iban_gen_i(blz, kto, out retval);
            iban = Marshal.PtrToStringAnsi(iban_p);
            kc_free(iban_p);
            return iban;
        }
        /* Funktion iban_gen(String blz, String kto,out Int32 retval) +§§§4 */
        public static String iban_gen(String blz, String kto, out Int32 retval)
        {
            IntPtr iban_p;
            String iban;

            iban_p = iban_gen_i(blz, kto, out retval);
            iban = Marshal.PtrToStringAnsi(iban_p);
            kc_free(iban_p);
            return iban;
        }
        #endregion

        /* Funktion iban_check() +§§§3 */
        #region iban_check()

        /* ###########################################################################
         * # Die Funktion iban_check prüft, ob die Prüfsumme des IBAN ok ist und     #
         * # testet außerdem noch die BLZ/Konto Kombination. Für den Test des Kontos #
         * # wird keine Initialisierung gemacht; diese muß vorher erfolgen. Der      #
         * # Rückgabewert ist das Ergebnis der IBAN-Prüfung; in der (optionalen)     #
         * # Variablen retval wird das Ergebnis der Kontoprüfung (nur für deutsche   #
         * # Konten möglich) zurückgegeben.                                          #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion iban_check(String iban) +§§§4 */
        static Int32 iban_check(String iban)
        {
            Int32 retval;

            return iban_check_i(iban, out retval);
        }
        /* Funktion iban_check(String iban, out Int32 retval) +§§§4 */
        public static Int32 iban_check(String iban, out Int32 retval)
        {
            return iban_check_i(iban, out retval);
        }
        #endregion

        /* Funktion ipi_gen() +§§§3 c*/
        #region ipi_gen()

        /* ###########################################################################
         * # Die Funktion ipi_gen generiert einen Strukturierten Verwendungszweck    #
         * # für eine IPI (International Payment Instruction). Der Zweck darf nur    #
         * # Buchstaben und Zahlen enthalten; Buchstaben werden dabei in Großbuch-   #
         * # staben umgewandelt. Andere Zeichen sind hier nicht zulässig. Der        #
         * # Verwendungszweck wird links mit Nullen bis auf 18 Byte aufgefüllt, dann #
         * # die Prüfsumme berechnet und eingesetzt. Optional wird auch eine         #
         * # Papierform (mit einem Leerzeichen nach jeweils 5 Zeichen) sowie ein     #
         * # Statuscode zurückgegeben.                                               #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion ipi_gen(String zweck) +§§§4 */
        static String ipi_gen(String zweck)
        {
            Int32 retval;
            IntPtr papier_p, ipi_p;
            String ipi;

            ipi_p = kc_alloc(24, out retval);
            papier_p = kc_alloc(28, out retval);
            retval = ipi_gen_i(zweck, out ipi_p, out papier_p);
            ipi = Marshal.PtrToStringAnsi(ipi_p);
            kc_free(papier_p);
            kc_free(ipi_p);
            return ipi;
        }
        /* Funktion ipi_gen(String zweck, out Int32 retval) +§§§4 */
        static String ipi_gen(String zweck, out Int32 retval)
        {
            IntPtr papier_p, ipi_p;
            String ipi;

            ipi_p = kc_alloc(24, out retval);
            papier_p = kc_alloc(28, out retval);
            retval = ipi_gen_i(zweck, out ipi_p, out papier_p);
            ipi = Marshal.PtrToStringAnsi(ipi_p);
            kc_free(papier_p);
            kc_free(ipi_p);
            return ipi;
        }
        /* Funktion ipi_gen(String zweck, out String papier) +§§§4 */
        static String ipi_gen(String zweck, out String papier)
        {
            Int32 retval;
            IntPtr papier_p, ipi_p;
            String ipi;

            ipi_p = kc_alloc(24, out retval);
            papier_p = kc_alloc(28, out retval);
            retval = ipi_gen_i(zweck, out ipi_p, out papier_p);
            ipi = Marshal.PtrToStringAnsi(ipi_p);
            papier = Marshal.PtrToStringAnsi(papier_p);
            kc_free(papier_p);
            kc_free(ipi_p);
            return ipi;
        }
        /* Funktion ipi_gen(String zweck, out String papier, out Int32 retval) +§§§4 */
        static String ipi_gen(String zweck, out String papier, out Int32 retval)
        {
            IntPtr papier_p, ipi_p;
            String ipi;

            ipi_p = kc_alloc(24, out retval);
            papier_p = kc_alloc(28, out retval);
            retval = ipi_gen_i(zweck, out ipi_p, out papier_p);
            ipi = Marshal.PtrToStringAnsi(ipi_p);
            papier = Marshal.PtrToStringAnsi(papier_p);
            kc_free(papier_p);
            kc_free(ipi_p);
            return ipi;
        }
        #endregion

        /* Funktion ipi_check() +§§§3 */
        #region ipi_check()

        /* ###########################################################################
         * # Die Funktion ipi_check testet einen Strukturierten Verwendungszweck     #
         * # für eine IPI (International Payment Instruction). Der Zweck darf nur    #
         * # Buchstaben und Zahlen enthalten und muß genau 20 Byte lang sein, wobei  #
         * # eingestreute Blanks oder Tabs ignoriert werden.                         #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion ipi_check(String ipi) +§§§4 */
        /* Die Funktion kann direkt aus der DLL aufgerufen werden, ohne Wrapper */
        #endregion
        #endregion

        /* C#-Definitionen: Suchfunktionen +§§§2 */
        #region Suchfunktionen

        /* Die Suchfunktionen der C-Bibliothek stellen ein Low-Level Interface
         * zur Verfügung, das durch C#.net nur schlecht unterstützt wird. Die
         * Funktionen sind so implementiert, daß zunächst ein Array mit den
         * Indizes der Bankleitzahlen in der gewünschten Suchordnung erstellt
         * (bzw. eingelesen) wird; für eine konkrete Suche wird dann ein
         * Pointer auf den ersten Index, der die Suchkriterien erfüllt sowie
         * die Anzahl der Banken, die das Kriterium erfüllen, zurückgegeben.
         * Auch für die Zweigstellen wird nur ein Pointer auf ein Array
         * zurückgegeben, das für jeden Index die Nummer der jeweiligen
         * Zweigstelle enthält.
         *
         * Da C#.net einen wahlfreien Zugriff in IntPtr-Feldern (mit einem
         * beliebigem Startindex, normalerweise ungleich 0) - soweit ich bis
         * jetzt gesehen habe - nicht unterstützt, wurde eine zusätzliche
         * Funktion konto_check_idx2blz() geschrieben, das zu einem gegebenen
         * Index BLZ und Zweigstelle zurückliefert. Die Funktion ist erst ab
         * Version 4.0 verfügbar; für frühere Versionen der DLL sind die
         * Suchfunktionen daher nicht verwendbar.
         */

        /* Funktion bank_suche_bic() +§§§3 */
        #region bank_suche_bic()

        /* ###########################################################################
         * # bank_suche_bic(): Banken mit gegebenem BIC suchen.                      #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_suche_bic(String bic) +§§§4 */
        static Int32[] bank_suche_bic(String bic)
        {
            Int32 retval;
            return bank_suche_bic(bic, out retval);
        }
        /* Funktion bank_suche_bic(String bic, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_bic(String bic, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_bic(bic, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
            return blz_a;
        }
        /* Funktion bank_suche_bic(String bic, out int[] zweigstellen) +§§§4 */
        static Int32[] bank_suche_bic(String bic, out int[] zweigstellen)
        {
            Int32 retval;
            return bank_suche_bic(bic, out zweigstellen, out retval);
        }
        /* Funktion bank_suche_bic(String bic, out int[] zweigstellen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_bic(String bic, out int[] zweigstellen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_bic(bic, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            zweigstellen = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
            {
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
                zweigstellen[i] = zw;
            }
            return blz_a;
        }
        #endregion

        /* Funktion bank_suche_namen() +§§§3 */
        #region bank_suche_namen()

        /* ###########################################################################
         * # bank_suche_namen: Banken mit gegebenem Langnamen suchen.                #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_suche_namen(String namen) +§§§4 */
        static Int32[] bank_suche_namen(String namen)
        {
            Int32 retval;
            return bank_suche_namen(namen, out retval);
        }
        /* Funktion bank_suche_namen(String namen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_namen(String namen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_namen(namen, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
            return blz_a;
        }
        /* Funktion bank_suche_namen(String namen, out int[] zweigstellen) +§§§4 */
        static Int32[] bank_suche_namen(String namen, out int[] zweigstellen)
        {
            Int32 retval;
            return bank_suche_namen(namen, out zweigstellen, out retval);
        }
        /* Funktion bank_suche_namen(String namen, out int[] zweigstellen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_namen(String namen, out int[] zweigstellen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_namen(namen, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            zweigstellen = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
            {
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
                zweigstellen[i] = zw;
            }
            return blz_a;
        }
        #endregion

        /* Funktion bank_suche_namen_kurz() +§§§3 */
        #region bank_suche_namen_kurz()

        /* ###########################################################################
         * # bank_suche_namen_kurz: Banken gegebenem Kurznamen suchen.               #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_suche_namen_kurz(String namen_kurz) +§§§4 */
        static Int32[] bank_suche_namen_kurz(String namen_kurz)
        {
            Int32 retval;
            return bank_suche_namen_kurz(namen_kurz, out retval);
        }
        /* Funktion bank_suche_namen_kurz(String namen_kurz, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_namen_kurz(String namen_kurz, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_namen_kurz(namen_kurz, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
            return blz_a;
        }
        /* Funktion bank_suche_namen_kurz(String namen_kurz, out int[] zweigstellen) +§§§4 */
        static Int32[] bank_suche_namen_kurz(String namen_kurz, out int[] zweigstellen)
        {
            Int32 retval;
            return bank_suche_namen_kurz(namen_kurz, out zweigstellen, out retval);
        }
        /* Funktion bank_suche_namen_kurz(String namen_kurz, out int[] zweigstellen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_namen_kurz(String namen_kurz, out int[] zweigstellen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_namen_kurz(namen_kurz, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            zweigstellen = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
            {
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
                zweigstellen[i] = zw;
            }
            return blz_a;
        }
        #endregion

        /* Funktion bank_suche_ort() +§§§3 */
        #region bank_suche_ort()

        /* ###########################################################################
         * # bank_suche_ort: Banken in einem gegebenen Ort suchen.                   #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_suche_ort(String ort) +§§§4 */
        static Int32[] bank_suche_ort(String ort)
        {
            Int32 retval;
            return bank_suche_ort(ort, out retval);
        }
        /* Funktion bank_suche_ort(String ort, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_ort(String ort, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_ort(ort, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
            return blz_a;
        }
        /* Funktion bank_suche_ort(String ort, out int[] zweigstellen) +§§§4 */
        static Int32[] bank_suche_ort(String ort, out int[] zweigstellen)
        {
            Int32 retval;
            return bank_suche_ort(ort, out zweigstellen, out retval);
        }
        /* Funktion bank_suche_ort(String ort, out int[] zweigstellen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_ort(String ort, out int[] zweigstellen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_ort(ort, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            zweigstellen = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
            {
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
                zweigstellen[i] = zw;
            }
            return blz_a;
        }
        #endregion

        /* Funktion bank_suche_plz() +§§§3 */
        #region bank_suche_plz()

        /* ###########################################################################
         * # bank_suche_plz: Banken mit vorgegebener PLZ oder PLZ zwischen plz1 und  #
         * # plz2 suchen.                                                            #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_suche_plz(Int32 plz) +§§§4 */
        static Int32[] bank_suche_plz(Int32 plz)
        {
            Int32 retval;
            return bank_suche_plz(plz, plz, out retval);
        }
        /* Funktion bank_suche_plz(Int32 plz1, Int32 plz2) +§§§4 */
        static Int32[] bank_suche_plz(Int32 plz1, Int32 plz2)
        {
            Int32 retval;
            return bank_suche_plz(plz1, plz2, out retval);
        }
        /* Funktion bank_suche_plz(Int32 plz1, Int32 plz2, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_plz(Int32 plz1, Int32 plz2, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_plz(plz1, plz2, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
            return blz_a;
        }
        /* Funktion bank_suche_plz(Int32 plz1, Int32 plz2, out int[] zweigstellen) +§§§4 */
        static Int32[] bank_suche_plz(Int32 plz1, Int32 plz2, out int[] zweigstellen)
        {
            Int32 retval;
            return bank_suche_plz(plz1, plz2, out zweigstellen, out retval);
        }
        /* Funktion bank_suche_plz(Int32 plz1, Int32 plz2, out int[] zweigstellen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_plz(Int32 plz1, Int32 plz2, out int[] zweigstellen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_plz(plz1, plz2, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            zweigstellen = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
            {
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
                zweigstellen[i] = zw;
            }
            return blz_a;
        }
        #endregion

        /* Funktion bank_suche_blz() +§§§3 */
        #region bank_suche_blz()

        /* ###########################################################################
         * # bank_suche_blz: Banken mit vorgegebener BLZ oder BLZ zwischen blz1 und  #
         * # blz2 suchen.                                                            #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_suche_blz(Int32 blz) +§§§4 */
        static Int32[] bank_suche_blz(Int32 blz)
        {
            Int32 retval;
            return bank_suche_blz(blz, blz, out retval);
        }
        /* Funktion bank_suche_blz(Int32 blz1, Int32 blz2) +§§§4 */
        static Int32[] bank_suche_blz(Int32 blz1, Int32 blz2)
        {
            Int32 retval;
            return bank_suche_blz(blz1, blz2, out retval);
        }
        /* Funktion bank_suche_blz(Int32 blz1, Int32 blz2, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_blz(Int32 blz1, Int32 blz2, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_blz(blz1, blz2, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
            return blz_a;
        }
        /* Funktion bank_suche_blz(Int32 blz1, Int32 blz2, out int[] zweigstellen) +§§§4 */
        static Int32[] bank_suche_blz(Int32 blz1, Int32 blz2, out int[] zweigstellen)
        {
            Int32 retval;
            return bank_suche_blz(blz1, blz2, out zweigstellen, out retval);
        }
        /* Funktion bank_suche_blz(Int32 blz1, Int32 blz2, out int[] zweigstellen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_blz(Int32 blz1, Int32 blz2, out int[] zweigstellen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_blz(blz1, blz2, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            zweigstellen = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
            {
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
                zweigstellen[i] = zw;
            }
            return blz_a;
        }
        #endregion

        /* Funktion bank_suche_pz() +§§§3 */
        #region bank_suche_pz()

        /* ###########################################################################
         * # bank_suche_pz: Banken mit vorgegebenem Prüfzifferverfahren pz oder      #
         * # Prüfzifferverfahren zwischen pz1 und pz2 suchen.                        #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_suche_pz(Int32 pz) +§§§4 */
        static Int32[] bank_suche_pz(Int32 pz)
        {
            Int32 retval;
            return bank_suche_pz(pz, pz, out retval);
        }
        /* Funktion bank_suche_pz(Int32 pz1, Int32 pz2) +§§§4 */
        static Int32[] bank_suche_pz(Int32 pz1, Int32 pz2)
        {
            Int32 retval;
            return bank_suche_pz(pz1, pz2, out retval);
        }
        /* Funktion bank_suche_pz(Int32 pz1, Int32 pz2, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_pz(Int32 pz1, Int32 pz2, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_pz(pz1, pz2, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
            return blz_a;
        }
        /* Funktion bank_suche_pz(Int32 pz1, Int32 pz2, out int[] zweigstellen) +§§§4 */
        static Int32[] bank_suche_pz(Int32 pz1, Int32 pz2, out int[] zweigstellen)
        {
            Int32 retval;
            return bank_suche_pz(pz1, pz2, out zweigstellen, out retval);
        }
        /* Funktion bank_suche_pz(Int32 pz1, Int32 pz2, out int[] zweigstellen, out Int32 retval) +§§§4 */
        static Int32[] bank_suche_pz(Int32 pz1, Int32 pz2, out int[] zweigstellen, out Int32 retval)
        {
            Int32 anzahl, rv, i, zw;
            IntPtr start_idx, zs, base_name, blz_base;

            retval = lut_suche_pz(pz1, pz2, out anzahl, out start_idx, out zs, out base_name, out blz_base);
            int[] idx_a = new int[anzahl];
            int[] blz_a = new int[anzahl];
            zweigstellen = new int[anzahl];
            Marshal.Copy(start_idx, idx_a, 0, anzahl);
            for (i = 0; i < anzahl; i++)
            {
                blz_a[i] = konto_check_idx2blz(idx_a[i], out zw, out rv);
                zweigstellen[i] = zw;
            }
            return blz_a;
        }
        #endregion

        #endregion

        /* C#-Definitionen: Funktionen für die LUT-datei +§§§2 */
        #region Funktionen für die LUT-datei
        /* Funktion bank_blz() +§§§3 */
        #region Funktion bank_blz()

        /* ###########################################################################
         * # bank_blz(): Test ob eine BLZ existiert                                  #
         * # Diese Funktion testet, ob eine BLZ (und Zweigstelle, falls gewünscht)   #
         * # existiert und gültig ist.                                               #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_blz(String blz) +§§§4 */
        static Int32 bank_blz(String blz)
        {
            return lut_blz(blz, 0);
        }
        /* Funktion bank_blz(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_blz(String blz, Int32 zweigstelle)
        {
            return lut_blz(blz, zweigstelle);
        }
        #endregion

        /* Funktion lut_info() +§§§3 */
        #region Funktion lut_info()

        /* Funktion lut_info() */
        /* ###########################################################################
         * # Die Funktion lut_info() extrahiert die beiden Infoblocks aus einer      #
         * # LUT-Datei und vergleicht das Gültigkeitsdatum mit dem aktuellen Datum.  #
         * # Falls eine LUT-Datei keinen Infoblock oder kein Gültigkeitsdatum        #
         * # enthält, wird (in den Variablen valid1 bzw. valid2) ein entsprechender  #
         * # Fehlercode zurückgegeben.                                               #
         * #                                                                         #
         * # Falls als Dateiname NULL oder ein Leerstring übergeben wird, wird die   #
         * # Gültigkeit des aktuell geladenen Datensatzes bestimmt, und (optional)   #
         * # mit dem zugehörigen Infoblock zurückgegeben. In diesem Fall wird info2  #
         * # auf "" und valid2 auf LUT2_BLOCK_NOT_IN_FILE gesetzt.                   #
         * #                                                                         #
         * # Parameter:                                                              #
         * #    lut_name: Name der LUT-Datei oder NULL/Leerstring                    #
         * #    info1:    Rückgabestring mit dem primären Infoblock                  #
         * #    info2:    Rückgabestring mit dem sekundären Infoblock                #
         * #    valid1:   Statusvariable für den primären Datensatz                  #
         * #    valid2:   Statusvariable für den sekundären Datensatz                #
         * #                                                                         #
         * # Rückgabewerte:                                                          #
         * #    OK:                     ok, weiteres in valid1 und valid2            #
         * #    LUT2_NOT_INITIALIZED:   die library wurde noch nicht initialisiert   #
         * #                                                                         #
         * # Werte für valid1 und valid2:                                            #
         * #    LUT2_VALID:             Der Datenblock ist aktuell gültig            #
         * #    LUT2_NO_LONGER_VALID:   Der Datenblock ist nicht mehr gültig         #
         * #    LUT2_NOT_YET_VALID:     Der Datenblock ist noch nicht gültig         #
         * #    LUT2_NO_VALID_DATE:     Der Datenblock enthält kein Gültigkeitsdatum #
         * #    LUT2_BLOCK_NOT_IN_FILE: Die LUT-Datei enthält den Infoblock nicht    #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion lut_info(out String info,out Int32 valid) +§§§4 */
        static Int32 lut_info(out String info, out Int32 valid)
        {
            Int32 retval, valid2;
            IntPtr info1_p, info2_p;

            retval = lut_info_i("", out info1_p, out info2_p, out valid, out valid2);
            info = Marshal.PtrToStringAnsi(info1_p);
            kc_free(info1_p);
            kc_free(info2_p);
            return retval;
        }
        /* Funktion lut_info(String lutfile,Int32 set,out String info,out Int32 valid) +§§§4 */
        static Int32 lut_info(String lutfile, Int32 set, out String info, out Int32 valid)
        {
            Int32 retval, valid1, valid2;
            IntPtr info1_p, info2_p;

            retval = lut_info_i(lutfile, out info1_p, out info2_p, out valid1, out valid2);
            if (set == 1)
            {
                info = Marshal.PtrToStringAnsi(info1_p);
                valid = valid1;
            }
            else if (set == 2)
            {
                info = Marshal.PtrToStringAnsi(info2_p);
                valid = valid2;
            }
            else
            {
                info = "";
                valid = 0;
            }
            kc_free(info1_p);
            kc_free(info2_p);
            return retval;
        }
        /* Funktion lut_info(String lutfile,out String info1,out Int32 valid1,out String info2,out Int32 valid2) +§§§4 */
        static Int32 lut_info(String lutfile, out String info1, out Int32 valid1, out String info2, out Int32 valid2)
        {
            Int32 retval;
            IntPtr info1_p, info2_p;

            retval = lut_info_i(lutfile, out info1_p, out info2_p, out valid1, out valid2);
            info1 = Marshal.PtrToStringAnsi(info1_p);
            info2 = Marshal.PtrToStringAnsi(info2_p);
            kc_free(info1_p);
            kc_free(info2_p);
            return retval;
        }
        #endregion

        /* Funktion generate_lut() +§§§3 */
        #region Funktion generate_lut()

        /* ###########################################################################
         * # generate_lut(): LUT-Datei generieren.                                   #
         * #                                                                         #
         * # Diese Funktion generiert aus der Textdatei der Deutschen Bundesbank     #
         * # eine LUT-Datei die für die konto_check Bibliothek benötigt wird.        #
         * # Die Felder der Bundesbankdatei werden dabei in einzelnen Blocks in der  #
         * # LUT-Datei gespeichert, die unabhängig voneinander eingelesen werden     #
         * # können und in einem (normalerweise mittels zlib) komprimierten Format   #
         * # gespeichert werden. In einer LUT-Datei können zwei Datensätze (d.h.     #
         * # zwei Bundesbankdateien) mit unterschiedlichem Gültigkeitsdatum          #
         * # gespeichert werden. Die Entscheidung welcher Datensatz aktuell gültig   #
         * # ist wird bei der Initialisierung anhand des Systemdatums gefällt.       #
         * # Es ist ferner möglich, nur die Daten der Hauptstellen in die LUT-Datei  #
         * # aufzunehmen; die Datei wird dadurch natürlich wesentlich kleiner.       #
         * #                                                                         #
         * # Folgende Parameter werden unterstützt:                                  #
         * #                                                                         #
         * # inputname:      Name der Bundesbankdatei (Textversion)                  #
         * #                                                                         #
         * # outputname:     Name zu generierenden LUT-Datei                         #
         * #                                                                         #
         * # user_info:      Kommentarfeld in der LUT-Datei                          #
         * #                                                                         #
         * # gueltigkeit:    Gültigkeit des Datensatzes im Format JJJJMMDD-JJJJMMDD  #
         * #                                                                         #
         * # iban_blacklist: Name der Datei mit den Instituten, die einer            #
         * #                 Selbstberechnung der IBAN nicht zugestimmt haben.       #
         * #                 Nähere Infos und Weblinks zu dieser Datei gibt es bei   #
         * #                 der Funktion lut_keine_iban_berechnung() (s.u.).        #
         * #                                                                         #
         * # felder:         Integer (0...9), welche Blocks in die LUT-Datei         #
         * #                 aufgenommen werden sollen. Eine Liste der Blocks findet #
         * #                 sich im Anhang der Datei 00liesmich.pdf.                #
         * #                                                                         #
         * # filialen:       Flag (0 oder 1), ob die Daten der Filialen aufgenommen  #
         * #                 werden sollen.                                          #
         * #                                                                         #
         * # slots:          Anzahl Slots im Inhaltsverzeichnis der LUT-Datei. Diese #
         * #                 Zahl kann nachträglich nicht mehr geändert werden; sie  #
         * #                 gibt die maximale Anzahl Blocks an, die in der Datei    #
         * #                 enthalten sein können. Der Minimalwert für diesen       #
         * #                 Parameter ist in konto_check.h mit 40 festgelegt.       #
         * #                                                                         #
         * # set:            (Integer 0, 1 oder 2). Angabe welcher Datensatz         #
         * #                 geschrieben werden soll. Bei 0 wird die Datei neu       #
         * #                 angelegt und der Datensatz 1 geschrieben; bei 1 oder    #
         * #                 2 wird der entsprechende Datensatz an die LUT-Datei     #
         * #                 angehängt. Falls in der Datei schon Blocks mit derselben#
         * #                 Blocknummer enthalten sind, werden sie durch die neuen  #
         * #                 Blocks ersetzt.                                         #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion generate_lut(String inputname,String outputname) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname)
        {
            return generate_lut2_p(inputname, outputname, "", "", 0, 0, 0, 0, 0);
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info)
        {
            return generate_lut2_p(inputname, outputname, user_info, "", 0, 0, 0, 0, 0);
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit)
        {
            return generate_lut2_p(inputname, outputname, user_info, gueltigkeit, 0, 0, 0, 0, 0);
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,String iban_blacklist) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, String iban_blacklist)
        {
            Int32 retval;

            if ((retval = generate_lut2_p(inputname, outputname, user_info, gueltigkeit, 0, 0, 0, 0, 0)) <= 0) return retval;
            lut_keine_iban_berechnung_i(iban_blacklist, outputname, 0);
            return retval;
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,Int32 felder) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, Int32 felder)
        {
            return generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, 0, 0, 0, 0);
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,String iban_blacklist,Int32 felder) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, String iban_blacklist, Int32 felder)
        {
            Int32 retval;

            if ((retval = generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, 0, 0, 0, 0)) <= 0) return retval;
            lut_keine_iban_berechnung_i(iban_blacklist, outputname, 0);
            return retval;
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,Int32 felder,Int32 filialen) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, Int32 felder, Int32 filialen)
        {
            return generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, filialen, 0, 0, 0);
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,String iban_blacklist,Int32 felder,Int32 filialen) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, String iban_blacklist, Int32 felder, Int32 filialen)
        {
            Int32 retval;

            if ((retval = generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, filialen, 0, 0, 0)) <= 0) return retval;
            lut_keine_iban_berechnung_i(iban_blacklist, outputname, 0);
            return retval;
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,Int32 felder,Int32 filialen,Int32 set) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, Int32 felder, Int32 filialen, Int32 set)
        {
            return generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, filialen, 0, 0, set);
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,String iban_blacklist,Int32 felder,Int32 filialen,Int32 set) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, String iban_blacklist, Int32 felder, Int32 filialen, Int32 set)
        {
            Int32 retval;

            if ((retval = generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, filialen, 0, 0, set)) <= 0) return retval;
            lut_keine_iban_berechnung_i(iban_blacklist, outputname, 0);
            return retval;
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,Int32 felder,Int32 filialen,Int32 slots,Int32 set) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, Int32 felder, Int32 filialen, Int32 slots, Int32 set)
        {
            return generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, filialen, slots, 0, set);
        }
        /* Funktion generate_lut(String inputname,String outputname,String user_info, String gueltigkeit,String iban_blacklist,Int32 felder,Int32 filialen,Int32 slots,Int32 set) +§§§4 */
        static Int32 generate_lut(String inputname, String outputname, String user_info,
                 String gueltigkeit, String iban_blacklist, Int32 felder, Int32 filialen, Int32 slots, Int32 set)
        {
            Int32 retval;

            if ((retval = generate_lut2_p(inputname, outputname, user_info, gueltigkeit, felder, filialen, slots, 0, set)) <= 0) return retval;
            lut_keine_iban_berechnung_i(iban_blacklist, outputname, 0);
            return retval;
        }
        #endregion

        /* Funktion lut_keine_iban_berechnung() +§§§3 */
        #region Funktion lut_keine_iban_berechnung()

        /* ############################################################################
         * # Die Funktion lut_keine_iban_berechnung() konvertiert die Liste der       #  
         * # Banken, die einer IBAN-Berechnung nicht zugestimmt haben in das interne  #
         * # Format für konto_check. Als Eingabedatei wird die Datei CONFIG.INI des   #
         * # SEPA Account Converters der Sparkassen benutzt, die Ausgabe wird direkt  #
         * # als Block in die LUT-Datei geschrieben. Der Block wird automatisch beim  #
         * # Initialisieren eingelesen und von der Funktion iban_gen() ausgewertet.   #
         * #                                                                          #
         * # Hier ein Auszug aus der Anleitung des SEPA Account Converters:           #
         * #                                                                          #
         * # Der SEPA Account Converter ist so eingestellt, dass nur                  #
         * # Kontoverbindungen in IBAN und BIC umgerechnet werden, bei denen das      #
         * # ausgebende Kreditinstitut der Umrechnung zugestimmt hat.                 #
         * # Kreditinstitute, welche einer Umrechnung nicht zugestimmt haben und      #
         * # welche zum Teil spezielle, dem SEPA Account Converter nicht bekannte     #
         * # Umrechnungsmethoden verwenden, sind in der Datei "CONFIG.INI"            #
         * # hinterlegt. Durch Löschen der Datei "CONFIG.INI" aus dem                 #
         * # Programmverzeichnis haben Sie die Möglichkeit, eine Umrechnung für alle  #
         * # Konten durchzuführen. Bitte beachten Sie dabei, dass die so erhaltenen   #
         * # IBAN und BIC fehlerhaft sein können und deshalb mit ihren Kunden zu      #
         * # überprüfen sind.                                                         #
         * ############################################################################
         */

        /* Weblinks:
         * https://www.sparkasse-rhein-neckar-nord.de/pdf/content/sepa/kurzanleitung.pdf
         * https://www.sparkasse-rhein-neckar-nord.de/firmenkunden/internationales_geschaeft/sepa/vorteile/index.php
         * https://www.sparkasse-rhein-neckar-nord.de/firmenkunden/internationales_geschaeft/sepa/vorteile/sepa_account_converter.msi
         * http://www.sfirm.de/update/prgupd.htm
         */

        /* Funktion lut_keine_iban_berechnung(String iban_blacklist,String lutfile) +§§§4 */
        static Int32 lut_keine_iban_berechnung(String iban_blacklist, String lutfile)
        {
            return lut_keine_iban_berechnung_i(iban_blacklist, lutfile, 0);
        }
        /* Funktion lut_keine_iban_berechnung(String iban_blacklist,String lutfile,Int32 set) +§§§4 */
        static Int32 lut_keine_iban_berechnung(String iban_blacklist, String lutfile, Int32 set)
        {
            return lut_keine_iban_berechnung_i(iban_blacklist, lutfile, set);
        }
        #endregion

        /* Funktion lut_dir_dump_str() +§§§3 */
        #region Funktion lut_dir_dump_str()

        /* ###########################################################################
         * # Die Funktion lut_dir_dump_str liest eine LUT-Datei und gibt die Infos   #
         * # zu den enthaltenen Blocks im Ausgabestring zurück. Außerdem wird noch   #
         * # die Gesamtgröße der Daten (sowohl komprimiert als auch unkomprimiert)   #
         * # ausgegeben.                                                             #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion lut_dir_dump_str(String blz) +§§§4 */
        static String lut_dir_dump_str(String lutfile)
        {
            Int32 retval;
            IntPtr dptr;
            String lut_dir;

            retval = lut_dir_dump_str_i(lutfile, out dptr);
            lut_dir = Marshal.PtrToStringAnsi(dptr);
            kc_free(dptr);
            return lut_dir;
        }
        /* Funktion bank_filialen(String blz,out Int32 retval) +§§§4 */
        static String lut_dir_dump_str(String lutfile, out Int32 retval)
        {
            IntPtr dptr;
            String lut_dir;

            retval = lut_dir_dump_str_i(lutfile, out dptr);
            lut_dir = Marshal.PtrToStringAnsi(dptr);
            kc_free(dptr);
            return lut_dir;
        }
        #endregion

        /* Funktion bank_filialen() +§§§3 */
        #region Funktion bank_filialen()

        /* ###########################################################################
         * # bank_filialen(): Anzahl der Filialen zu einer gegebenen Bankleitzahl    #
         * # bestimmen.                                                              #
         * #                                                                         #
         * # Copyright (C) 2007 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_filialen(String blz) +§§§4 */
        static Int32 bank_filialen(String blz)
        {
            Int32 retval;

            return lut_filialen(blz, out retval);
        }
        /* Funktion bank_filialen(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_filialen(String blz, out Int32 retval)
        {
            return lut_filialen(blz, out retval);
        }
        #endregion

        /* Die folgenden Funktionen haben jeweils drei Parameter: BLZ, Filiale
         * und retval. Die BLZ ist notwendig, Filiale und retval sind
         * optional. Falls die Filiale nicht angegeben wird wird 0 angenommen
         * (Hauptstelle). In der Variablen retval wird ein Statuscode zum
         * Funktionsaufruf zurückgegeben.
         */
        /* Funktion bank_name() +§§§3 */
        #region Funktion bank_name()

        /* ###########################################################################
         * # bank_name(): Banknamen (lange Form) bestimmen                           #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_name(String blz) +§§§4 */
        static String bank_name(String blz)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_name(blz, 0, out retval));
        }
        /* Funktion bank_name(String blz, out Int32 retval) +§§§4 */
        static String bank_name(String blz, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_name(blz, 0, out retval));
        }
        /* Funktion bank_name(String blz, Int32 zweigstelle) +§§§4 */
        static String bank_name(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_name(blz, zweigstelle, out retval));
        }
        /* Funktion bank_name(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static String bank_name(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_name(blz, zweigstelle, out retval));
        }
        #endregion

        /* Funktion bank_name_kurz() +§§§3 */
        #region Funktion bank_name_kurz()

        /* ###########################################################################
         * # bank_name_kurz(): Kurzbezeichnung mit Ort einer Bank bestimmen          #
         * #                                                                         #
         * # Kurzbezeichnung und Ort sollen für die Empfängerangaben auf Rechnungen  #
         * # und Formularen angegeben werden. Hierdurch wird eine eindeutige Zu-     #
         * # ordnung der eingereichten Zahlungsaufträge ermöglicht. Auf Grund der    #
         * # Regelungen in den Richtlinien beziehungsweise Zahlungsverkehrs-Abkommen #
         * # der deutschen Kreditwirtschaft ist die Länge der Angaben für die        #
         * # Bezeichnung des Kreditinstituts begrenzt.                               #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_name_kurz(String blz) +§§§4 */
        static String bank_name_kurz(String blz)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_name_kurz(blz, 0, out retval));
        }
        /* Funktion bank_name_kurz(String blz, out Int32 retval) +§§§4 */
        static String bank_name_kurz(String blz, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_name_kurz(blz, 0, out retval));
        }
        /* Funktion bank_name_kurz(String blz, Int32 zweigstelle) +§§§4 */
        static String bank_name_kurz(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_name_kurz(blz, zweigstelle, out retval));
        }
        /* Funktion bank_name_kurz(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static String bank_name_kurz(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_name_kurz(blz, zweigstelle, out retval));
        }
        #endregion

        /* Funktion bank_plz() +§§§3 */
        #region Funktion bank_plz()

        /* ###########################################################################
         * # bank_plz(): Postleitzahl bestimmen                                      #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_plz(String blz) +§§§4 */
        static Int32 bank_plz(String blz)
        {
            Int32 retval;
            return lut_plz(blz, 0, out retval);
        }
        /* Funktion bank_plz(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_plz(String blz, out Int32 retval)
        {
            return lut_plz(blz, 0, out retval);
        }
        /* Funktion bank_plz(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_plz(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return lut_plz(blz, zweigstelle, out retval);
        }
        /* Funktion bank_plz(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static Int32 bank_plz(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return lut_plz(blz, zweigstelle, out retval);
        }
        #endregion

        /* Funktion bank_ort() +§§§3 */
        #region Funktion bank_ort()

        /* ###########################################################################
         * # bank_ort(): Sitz einer Bank bestimmen                                   #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_ort(String blz) +§§§4 */
        static String bank_ort(String blz)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_ort(blz, 0, out retval));
        }
        /* Funktion bank_ort(String blz, out Int32 retval) +§§§4 */
        static String bank_ort(String blz, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_ort(blz, 0, out retval));
        }
        /* Funktion bank_ort(String blz, Int32 zweigstelle) +§§§4 */
        static String bank_ort(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_ort(blz, zweigstelle, out retval));
        }
        /* Funktion bank_ort(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static String bank_ort(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_ort(blz, zweigstelle, out retval));
        }
        #endregion

        /* Funktion bank_pan() +§§§3 */
        #region Funktion bank_pan()

        /* ###########################################################################
         * # bank_pan(): PAN-Nummer bestimmen                                        #
         * #                                                                         #
         * # Für den internationalen Kartenzahlungsverkehr mittels Bankkunden-       #
         * # karten haben die Spitzenverbände des Kreditgewerbes und die Deutsche    #
         * # Bundesbank eine gesonderte Institutsnummerierung festgelegt; danach     #
         * # erhält das kartenausgebende Kreditinstitut eine fünfstellige Instituts- #
         * # nummer für PAN (= Primary Account Number). Diese setzt sich zusammen    #
         * # aus der Institutsgruppennummer (grundsätzlich = vierte Stelle der       #
         * # Bankleitzahl) und einer nachfolgenden vierstelligen, von den einzelnen  #
         * # Institutionen frei gewählten Nummer. Abweichend hiervon ist den         #
         * # Mitgliedsinstituten des Bundesverbandes deutscher Banken e.V. sowie     #
         * # den Stellen der Deutschen Bundesbank stets die Institutsgruppennummer   #
         * # 2 zugewiesen worden.                                                    #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_pan(String blz) +§§§4 */
        static Int32 bank_pan(String blz)
        {
            Int32 retval;
            return lut_pan(blz, 0, out retval);
        }
        /* Funktion bank_pan(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_pan(String blz, out Int32 retval)
        {
            return lut_pan(blz, 0, out retval);
        }
        /* Funktion bank_pan(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_pan(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return lut_pan(blz, zweigstelle, out retval);
        }
        /* Funktion bank_pan(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static Int32 bank_pan(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return lut_pan(blz, zweigstelle, out retval);
        }
        #endregion

        /* Funktion bank_bic() +§§§3 */
        #region Funktion bank_bic()

        /* ###########################################################################
         * # bank_bic(): BIC (Bank Identifier Code) einer Bank bestimmen.            #
         * #                                                                         #
         * # Der Bank Identifier Code (BIC) besteht aus acht oder elf                #
         * # zusammenhängenden Stellen und setzt sich aus den Komponenten BANKCODE   #
         * # (4 Stellen), LÄNDERCODE (2 Stellen), ORTSCODE (2 Stellen) sowie ggf.    #
         * # einem FILIALCODE (3 Stellen) zusammen.                                  #
         * #                                                                         #
         * # Jedes Kreditinstitut führt grundsätzlich einen BIC je Bankleitzahl und  #
         * # teilt diesen der Deutschen Bundesbank mit. Ausnahmen hiervon können auf #
         * # Antrag für Bankleitzahlen zugelassen werden, die im BIC-gestützten      #
         * # Zahlungsverkehr (grenzüberschreitender Zahlungsverkehr und inländischer #
         * # Individualzahlungsverkehr) nicht verwendet werden.                      #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_bic(String blz) +§§§4 */
        static String bank_bic(String blz)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_bic(blz, 0, out retval));
        }
        /* Funktion bank_bic(String blz, out Int32 retval) +§§§4 */
        static String bank_bic(String blz, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_bic(blz, 0, out retval));
        }
        /* Funktion bank_bic(String blz, Int32 zweigstelle) +§§§4 */
        static String bank_bic(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return Marshal.PtrToStringAnsi(lut_bic(blz, zweigstelle, out retval));
        }
        /* Funktion bank_bic(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static String bank_bic(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return Marshal.PtrToStringAnsi(lut_bic(blz, zweigstelle, out retval));
        }
        #endregion

        /* Funktion bank_nr() +§§§3 */
        #region Funktion bank_nr()

        /* ###########################################################################
         * # bank_nr(): Nummer des Datensatzes in der BLZ-Datei                      #
         * #                                                                         #
         * # Bei jeder Neuanlage eines Datensatzes wird von der Deutschen Bundesbank #
         * # automatisiert eine eindeutige Nummer vergeben. Eine einmal verwendete   #
         * # Nummer wird nicht noch einmal vergeben.                                 #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_nr(String blz) +§§§4 */
        static Int32 bank_nr(String blz)
        {
            Int32 retval;
            return lut_nr(blz, 0, out retval);
        }
        /* Funktion bank_nr(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_nr(String blz, out Int32 retval)
        {
            return lut_nr(blz, 0, out retval);
        }
        /* Funktion bank_nr(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_nr(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return lut_nr(blz, zweigstelle, out retval);
        }
        /* Funktion bank_nr(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static Int32 bank_nr(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return lut_nr(blz, zweigstelle, out retval);
        }
        #endregion

        /* Funktion bank_pz() +§§§3 */
        #region Funktion bank_pz()

        /* ###########################################################################
         * # bank_pz(): Prüfzifferverfahren für eine Bankleitzahl. Das Verfahren wird#
         * # numerisch zurückgegeben, also z.B. 108 für die Methode A8.              #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_pz(String blz) +§§§4 */
        static Int32 bank_pz(String blz)
        {
            Int32 retval;
            return lut_pz(blz, 0, out retval);
        }
        /* Funktion bank_pz(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_pz(String blz, out Int32 retval)
        {
            return lut_pz(blz, 0, out retval);
        }
        /* Funktion bank_pz(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_pz(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return lut_pz(blz, zweigstelle, out retval);
        }
        /* Funktion bank_pz(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static Int32 bank_pz(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return lut_pz(blz, zweigstelle, out retval);
        }
        #endregion

        /* Funktion bank_aenderung() +§§§3 */
        #region Funktion bank_aenderung()

        /* ###########################################################################
         * # bank_aenderung(): Änderungskennzeichen einer Bank betimmen (A Addition, #
         * # M Modified, U Unchanged, D Deletion). Gelöschte Datensätze werden mit   #
         * # dem Kennzeichen 'D' gekennzeichnet und sind - als Hinweis - letztmalig  #
         * # in der Bankleitzahlendatei enthalten. Diese Datensätze sind ab dem      #
         * # Gültigkeitstermin der Bankleitzahlendatei im Zahlungsverkehr nicht mehr #
         * # zu verwenden.                                                           #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_aenderung(String blz) +§§§4 */
        static Int32 bank_aenderung(String blz)
        {
            Int32 retval;
            return lut_aenderung(blz, 0, out retval);
        }
        /* Funktion bank_aenderung(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_aenderung(String blz, out Int32 retval)
        {
            return lut_aenderung(blz, 0, out retval);
        }
        /* Funktion bank_aenderung(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_aenderung(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return lut_aenderung(blz, zweigstelle, out retval);
        }
        /* Funktion bank_aenderung(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static Int32 bank_aenderung(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return lut_aenderung(blz, zweigstelle, out retval);
        }
        #endregion

        /* Funktion bank_loeschung() +§§§3 */
        #region Funktion bank_loeschung()

        /* ###########################################################################
         * # bank_loeschung(): Hinweis auf eine beabsichtigte Bankleitzahllöschung   #
         * #                                                                         #
         * # Zur frühzeitigen Information der Teilnehmer am Zahlungsverkehr und      #
         * # zur Beschleunigung der Umstellung der Bankverbindung kann ein Kredit-   #
         * # institut, das die Löschung einer Bankleitzahl mit dem Merkmal 1 im      #
         * # Feld 2 (Hauptstelle) beabsichtigt, die Löschung ankündigen. Die         #
         * # Ankündigung kann erfolgen, sobald das Kreditinstitut seine Kunden       #
         * # über die geänderte Kontoverbindung informiert hat. Es wird empfohlen,   #
         * # diese Ankündigung mindestens eine Änderungsperiode vor der              #
         * # eigentlichen Löschung anzuzeigen.                                       #
         * #                                                                         #
         * # Das Feld enthält das Merkmal 0 (keine Angabe) oder 1 (BLZ im Feld 1     #
         * # ist zur Löschung vorgesehen).                                           #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_loeschung(String blz) +§§§4 */
        static Int32 bank_loeschung(String blz)
        {
            Int32 retval;
            return lut_loeschung(blz, 0, out retval);
        }
        /* Funktion bank_loeschung(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_loeschung(String blz, out Int32 retval)
        {
            return lut_loeschung(blz, 0, out retval);
        }
        /* Funktion bank_loeschung(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_loeschung(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return lut_loeschung(blz, zweigstelle, out retval);
        }
        /* Funktion bank_loeschung(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static Int32 bank_loeschung(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return lut_loeschung(blz, zweigstelle, out retval);
        }
        #endregion

        /* Funktion bank_nachfolge_blz() +§§§3 */
        #region Funktion bank_nachfolge_blz()

        /* ###########################################################################
         * # bank_nachfolge_blz(): entweder 0 (Bankleitzahl ist nicht zur Löschung   #
         * # vorgesehen, bzw. das Institut hat keine Nachfolge-BLZ veröffentlicht)   #
         * # oder eine Bankleitzahl. Eine Bankleitzahl kann nur für Hauptstellen an- #
         * # gegeben werden werden, wenn die Bankleitzahl zur Löschung angekündigt   #
         * # wurde (bank_loeschung()==1) oder die Bankleitzahl zum aktuellen Gültig- #
         * # keitstermin gelöscht wird (bank_aenderung()=='D').                      #
         * #                                                                         #
         * # Copyright (C) 2011 Michael Plugge <m.plugge@hs-mannheim.de>             #
         * ###########################################################################
         */

        /* Funktion bank_nachfolge_blz(String blz) +§§§4 */
        static Int32 bank_nachfolge_blz(String blz)
        {
            Int32 retval;
            return lut_nachfolge_blz(blz, 0, out retval);
        }
        /* Funktion bank_nachfolge_blz(String blz, out Int32 retval) +§§§4 */
        static Int32 bank_nachfolge_blz(String blz, out Int32 retval)
        {
            return lut_nachfolge_blz(blz, 0, out retval);
        }
        /* Funktion bank_nachfolge_blz(String blz, Int32 zweigstelle) +§§§4 */
        static Int32 bank_nachfolge_blz(String blz, Int32 zweigstelle)
        {
            Int32 retval;
            return lut_nachfolge_blz(blz, zweigstelle, out retval);
        }
        /* Funktion bank_nachfolge_blz(String blz, Int32 zweigstelle, out Int32 retval) +§§§4 */
        static Int32 bank_nachfolge_blz(String blz, Int32 zweigstelle, out Int32 retval)
        {
            return lut_nachfolge_blz(blz, zweigstelle, out retval);
        }
        #endregion

        #endregion
        #endregion
    }
}
