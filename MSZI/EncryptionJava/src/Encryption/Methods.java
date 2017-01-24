/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Encryption;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Random;
import java.util.Set;


/**
 *
 * @author Snow
 */
public class Methods {
    //Метод обратного шифрования
    static String ReverseString(String str){
        //convert str to char array
        char[] charArray = str.toCharArray();
        str = ""; //claear str
        for(short i = (short) (charArray.length - 1); i>=0; i--) //pass throw the array from the end
            str += Character.toString(charArray[i]); //write down the elements into the string
        return str;
    }
    
    //Шифр Цезаря
    static String Caesar(String str, short shift, String lan){ //lan = CYR or LAT
        short letter = 0, circle = 0;
        int lanStart = 97, lanEnd = 122;
        if(lan == "CYR"){
            lanStart = (int)'а';
            lanEnd = (int)'я';
        }
        str = str.toLowerCase(); //convert all of the characters in this string to lower case
        char[] charArray = str.toCharArray(); // convert str to array
        str = ""; //clear str
        for(short i = 0; i < charArray.length; i++){ //pass throw the array
            letter = (short) charArray[i]; //convert character to ascii code
            if(letter != 32){ //if letter is not space
                if(letter + shift <= lanEnd) //if letter + shift < alphabet length (z)
                    letter+=shift; // set letter = letter + shift
                else{ //else return to the alphabet start with shift additing
                    circle = (short) (letter + shift - (lanEnd + 1));
                    letter = (short) (lanStart + circle);
                }
            }
            str += Character.toString((char)letter); //convert letter to char
        }
        return str;
    }
    static String CaesarKeyEncrypt(String str, short shift, String key, String lan){
        short letter = 0, circle = 0;
        int lanStart = 97, lanEnd = 122, letters = 26;
        //Map<String, String> letterTable = new LinkedHashMap<String, String>();
        if(lan == "CYR"){
            lanStart = (int)'а';
            lanEnd = (int)'я';
            letters = 32;
        }
        char[] strArr = str.toCharArray();
        int strlength = str.length();
        str = "";
        //create table with alphabet
        Map letterTable = CreateTable(key, shift, lanStart, lanEnd);
        
        //encrypt
        Set keys = letterTable.keySet();
        String keycode, value;
        for(int j=0; j<strlength; j++){
            for (Iterator i = keys.iterator(); i.hasNext(); ) {
            keycode = (String) i.next();
                if(keycode.equals(Character.toString(strArr[j]))){
                    value = (String) letterTable.get(keycode);
                    str+=value;
                }
            }
        }
        return str;
    }
    
    static String CaesarKeyDecrypt(String str, short shift, String key, String lan){
        int lanStart = 97, lanEnd = 122, letters = 26;
        //Map<String, String> letterTable = new LinkedHashMap<String, String>();
        if(lan == "CYR"){
            lanStart = (int)'а';
            lanEnd = (int)'я';
            letters = 32;
        }
        char[] strArr = str.toCharArray();
        int strlength = str.length();
        str = "";
        //create table with alphabet
        Map letterTable = CreateTable(key, shift, lanStart, lanEnd);
        
        //decrypt
        Set keys = letterTable.keySet();
        String keycode, value;
        for(int j=0; j<strlength; j++){
            for (Iterator i = keys.iterator(); i.hasNext(); ) {
            keycode = (String) i.next();
            value = (String) letterTable.get(keycode);
                if(value.equals(Character.toString(strArr[j]))){
                    str+=keycode;
                }
            }
        }
        return str;
    }
    
    static String CheckRepeat(String str){
        char[] chArr = str.toCharArray();
        str = "";
        for(int i=0; i<str.length()-1; i++){
            for(int j=i+1; j<str.length(); j++){
                if(chArr[i] == chArr[j])
                    str += Character.toString(chArr[i]);
            }
        }
        return str;
    }
    
    //create for caesar with key encryption
    static Map CreateTable(String key, int shift, int lanStart, int lanEnd){
        Map<String, String> letterTable = new LinkedHashMap<String, String>();
        int keyStart = lanStart + shift;
        char[] keyArr = key.toCharArray();
         //////////create alphabet table////////////////
        int j = 0;
        //add keyword into the map
        for(int i=keyStart; i<keyStart+key.length(); i++){
            letterTable.put(Character.toString((char)i), Character.toString(keyArr[j]));
            j++;
        }
        //last part of alphabet
        keyStart+=key.length();
        int keylow = lanStart;
        while(keylow<=lanEnd){
            if(keyStart == lanEnd+1)
                keyStart = lanStart;
            if(!key.contains(Character.toString((char)keylow))){
                letterTable.put(Character.toString((char)keyStart), Character.toString((char)keylow));
                keyStart++;
                keylow++;
            }
            else
                keylow++;
        }
        //////////////////////////////
        return letterTable;
    }
    
    //Vigenere encryption
    static String Vigenere(String str, String key, String lan, boolean encrypt){
        int first, n;
        if(lan == "CYR"){
            first = (int)'а';
            n = 33;
        }
        else{
            first = (int)'a';
            n = 26;
        }
        
        String keyword = GenerateKeyword(str, key);
        char[] text = str.toCharArray();
        char[] keyArr = keyword.toCharArray();
        int num = 0;
        str = "";
        if(encrypt == true){
            //зашифровка
            for(int i = 0; i<text.length; i++){
                //num = (((int)text[i] + (int)keyArr[i])-2*first)%n;
                num = (((int)text[i] - first+1) + ((int)keyArr[i])-first+1)%n;
                str+= Character.toString((char)(num+first - 1));
            }
        }
        else{
        //расшифровка
            for(int i = 0; i<text.length; i++){
                num = ((int)text[i] - (int)keyArr[i]+n)%n;
                str+= Character.toString((char)(num+first));
            }
        }
        return str;
    }
    
    //Set the length of the keyword equal to the length of the text
    static String GenerateKeyword(String str, String key){
        String keyword ="";
        while(keyword.length() < str.length()){
            if((str.length() - keyword.length()) >=key.length())
                keyword+=key;
            else
                keyword+=key.substring(0, str.length()%key.length());
        }
        return keyword;
    }
    
    //Trithemius Table
    static char[][] CreateTrithemiusTable(String key, String lan, int rows, int cols){
        int last, first, k=0;
        char[][] a;
        if("CYR".equals(lan)){
            first = (int)'а';
            last = (int)'я';
        }
        else{
            first = (int)'a';
            last = (int)'z';
        }
        a = new char[rows][cols];
        char[] keyword = key.toCharArray();
        for(int i=0; i<rows; i++){
            for(int j=0; j<cols; j++){
                if(k<key.length()){
                    a[i][j] = keyword[k];
                }
                else{
                    while(first<=last){
                        if(!key.contains(Character.toString((char)first)) & (char)first != 'j'){
                            a[i][j] = (char)first;
                            first++;
                            break;
                        }
                        first++;
                    }
                }
                k++;
            }
        }
        return a;
    }
    
    static String Trithemius(String str, String key, String lan, boolean encrypt){
        int rows, cols;
        if("CYR".equals(lan)){
            rows = 4; cols = 8;
        }
        else{
            rows = 5; cols = 5;
        }
        str = str.toLowerCase();
        key = key.toLowerCase();
        str = str.replace('j', 'i');
        key = key.replace('j', 'i');
        key = RemoveRepeats(key);
        char[] text = str.toCharArray();
        str = "";
        int z = rows - 1;
        char[][] keytable = CreateTrithemiusTable(key, lan, rows, cols);
        if(encrypt==true){
            for(char item : text){
                for(int i=0; i<rows; i++){
                    for(int j=0; j<cols; j++){
                        if(item == keytable[i][j]){
                            if(i==z)
                                str+= Character.toString(keytable[0][j]);
                            else
                                str+= Character.toString(keytable[i+1][j]);
                        }
                    }
                }
            }
        }
        else{
            for(char item : text){
                for(int i=0; i<rows; i++){
                    for(int j=0; j<cols; j++){
                        if(item == keytable[i][j]){
                            if(i==0)
                                str+= Character.toString(keytable[rows-1][j]);
                            else
                                str+= Character.toString(keytable[i-1][j]);
                        }
                    }
                }
            }
        }
        return str;
    }
    
    static String RemoveRepeats(String str){
        char[] strCh = str.toCharArray();
        str = "";
        for(int i=0; i<strCh.length; i++){
            if(!str.contains(Character.toString(strCh[i])))
                str += Character.toString(strCh[i]);       
        }
        return str;
    }
    
    static String Playfair(String str, String key, String lan, boolean encrypt){
        int rows, cols;
        str = str.replaceAll(" ", "");
        if("CYR".equals(lan)){
            rows = 4; cols = 8;
            if(str.length()%2 != 0) str+="а";
        }
        else{
            rows = 5; cols = 5;
            if(str.length()%2 != 0) str+="a";
        }
        str = str.toLowerCase();
        key = key.toLowerCase();
        str = str.replace('j', 'i');
        key = key.replace('j', 'i');
        key = RemoveRepeats(key);
        char[] text = str.toCharArray();
        str = "";
        char[][] keytable = CreateTrithemiusTable(key, lan, rows, cols);
        if(encrypt == true){
            for(int i=0; i<text.length; i+=2){
                int[] l1pos = getPos(keytable, cols, rows, text[i]);
                int[] l2pos = getPos(keytable, cols, rows, text[i+1]);
                if(l1pos[0] != l2pos[0] && l1pos[1] != l2pos[1]){
                    //if 2 letters not in the same line or column
                    if(l1pos[0] < l2pos[0] && l1pos[1] < l2pos[1]){
                        str+=Character.toString(keytable[l1pos[0]][l2pos[1]]); //first letter
                        str+=Character.toString(keytable[l2pos[0]][l1pos[1]]); //second letter
                    }else{
                        str+=Character.toString(keytable[l1pos[0]][l2pos[1]]); //first letter
                        str+=Character.toString(keytable[l2pos[0]][l1pos[1]]); //second letter
                    }
                    continue;
                }
                //if 2 letters in the same column
                if(l1pos[1] == l2pos[1]){
                    if(l1pos[0] == rows - 1)
                        str+=Character.toString(keytable[0][l1pos[1]]); //first letter
                    else
                        str+=Character.toString(keytable[l1pos[0] + 1][l1pos[1]]); //first letter
                    if(l2pos[0] == rows - 1)
                        str+=Character.toString(keytable[0][l2pos[1]]); //second letter
                    else
                        str+=Character.toString(keytable[l2pos[0] + 1][l2pos[1]]); //second letter
                    continue;
                }
                //if 2 letters in the same line
                if(l1pos[0] == l2pos[0]){
                    if(l1pos[1] == cols - 1)
                        str+=Character.toString(keytable[l1pos[0]][0]); //first letter
                    else
                        str+=Character.toString(keytable[l1pos[0]][l1pos[1] + 1]); //first letter
                    if(l2pos[1] == cols - 1)
                        str+=Character.toString(keytable[l2pos[0]][0]); //second letter
                    else
                        str+=Character.toString(keytable[l2pos[0]][l2pos[1] + 1]); //second letter
                }
            }
        }
        else{
            for(int i=0; i<text.length; i+=2){
                int[] l1pos = getPos(keytable, cols, rows, text[i]);
                int[] l2pos = getPos(keytable, cols, rows, text[i+1]);
                if(l1pos[0] != l2pos[0] && l1pos[1] != l2pos[1]){
                    //if 2 letters not in the same line or column
                    if(l1pos[0] > l2pos[0] && l1pos[1] > l2pos[1]){
                        str+=Character.toString(keytable[l1pos[0]][l2pos[1]]); //first letter
                        str+=Character.toString(keytable[l2pos[0]][l1pos[1]]); //second letter
                    }else{
                        str+=Character.toString(keytable[l1pos[0]][l2pos[1]]); //first letter
                        str+=Character.toString(keytable[l2pos[0]][l1pos[1]]); //second letter
                    }
                    continue;
                }
                //if 2 letters in the same column
                if(l1pos[1] == l2pos[1]){
                    if(l1pos[0] == 0)
                        str+=Character.toString(keytable[rows - 1][l1pos[1]]); //first letter
                    else
                        str+=Character.toString(keytable[l1pos[0] - 1][l1pos[1]]); //first letter
                    if(l2pos[0] == 0)
                        str+=Character.toString(keytable[rows - 1][l2pos[1]]); //second letter
                    else
                        str+=Character.toString(keytable[l2pos[0] - 1][l2pos[1]]); //second letter
                    continue;
                }
                //if 2 letters in the same line
                if(l1pos[0] == l2pos[0]){
                    if(l1pos[1] == 0)
                        str+=Character.toString(keytable[l1pos[0]][cols - 1]); //first letter
                    else
                        str+=Character.toString(keytable[l1pos[0]][l1pos[1] - 1]); //first letter
                    if(l2pos[1] == 0)
                        str+=Character.toString(keytable[l2pos[0]][cols - 1]); //second letter
                    else
                        str+=Character.toString(keytable[l2pos[0]][l2pos[1] - 1]); //second letter
                }
            }
        }
        
        return str;
    }
    
    static int[] getPos(char[][] keytable, int col, int line, char letter){
        int[] pos = new int[2];
        for(int i=0; i<line; i++){
            for(int j=0; j<col; j++){
                if(keytable[i][j] == letter){
                    pos[0] = i;
                    pos[1] = j;
                    return pos;
                }
            }
        }
        return pos;
    }
    
    static String AnalitycEncrypt(String str, int[][]key, int keyLen, String lan, boolean encrypt){
        int first, n;
        str = str.toLowerCase();
        str = str.replaceAll(" ", "");
        if(lan == "CYR"){
            first = (int)'а';
            n = 33;
            if(str.length()%keyLen != 0){
            int len = str.length()%keyLen;
                for(int i=0; i<len; i++){
                    str+= 'а';
                }
            }
        }
        else{
            first = (int)'a';
            n = 26;
            if(str.length()%keyLen != 0){
            int len = str.length()%keyLen;
                for(int i=0; i<len; i++){
                    str+= 'a';
                }
            }
        }
        char[] strArr = str.toCharArray();
        int[][] resArr = new int[keyLen][1];
        int cnt = 0;
        int strlen = 0;
        str = "";
        while(strlen < strArr.length){
            for(int i=0; i<keyLen; i++){
                cnt=strlen;
                for(int j=0; j<1; j++){
                    resArr[i][j] = 0;
                    for(int k=0; k<keyLen; k++){
                       // if(cnt<strArr.length){
                            int let = (int)strArr[cnt]-first;
                            resArr[i][j]+= key[i][k] * let;
                            cnt++;
                        //}
                    }
                }
            }
            for(int i = 0; i<keyLen; i++){
                for(int j=0; j<1; j++){
                    str+= Integer.toString(resArr[i][j]) + " ";
                }
            }
            strlen+=keyLen;
            cnt=strlen;
        }
        
        return str;
    }
    
    static String AnalitycDecrypt(int[]encArr, int encLen, int[][]key, int keyLen, String lan, boolean encrypt){
        int first, n;
        String str = "";
        if(lan == "CYR"){
            first = (int)'а';
            n = 33;
        }
        else{
            first = (int)'a';
            n = 26;
        }
        int[][] resArr = new int[keyLen][1];
        int cnt = 0;
        int strlen = 0;
        while(strlen < encLen){
            for(int i=0; i<keyLen; i++){
                cnt=strlen;
                for(int j=0; j<1; j++){
                    resArr[i][j] = 0;
                    for(int k=0; k<keyLen; k++){
                       // if(cnt<strArr.length){
                            resArr[i][j]+= key[i][k] * encArr[cnt];
                            cnt++;
                        //}
                    }
                }
            }
            for(int i = 0; i<keyLen; i++){
                for(int j=0; j<1; j++){
                    str+= Character.toString((char)((resArr[i][j]%33)+first)) + " ";
                }
            }
            strlen+=keyLen;
            cnt=strlen;
        }
        return str;
    }
    
    
    static int[][] BuildMatrix(String str, int length){
        int[][] matrix = new int[length][length];
        int strpos = 0, indexOf = 0;
        str = str.replaceAll("\n", " ");
        
        String substr;
        for(int i=0; i< length; i++){
            for(int j=0; j<length; j++){
                indexOf = str.indexOf(" ", strpos);
                if(indexOf != -1){
                    substr = str.substring(strpos, indexOf);
                    strpos = indexOf+1;
                    matrix[i][j] = Integer.parseInt(substr);
                }
            }
        }
        substr = str.substring(strpos, str.length());
        matrix[length-1][length-1] = Integer.parseInt(substr);
        return matrix;
    }
    
    static int[] BuildMatrixOneDimensional(String str, int length){
        int[] matrix = new int[length];
        int strpos = 0, indexOf = 0;
        str = str.replaceAll("\n", " ");
        
        String substr;
        for(int i=0; i< length; i++){
                indexOf = str.indexOf(" ", strpos);
                if(indexOf != -1){
                    substr = str.substring(strpos, indexOf);
                    strpos = indexOf+1;
                    matrix[i] = Integer.parseInt(substr);
                }
        }
        //substr = str.substring(strpos, str.length());
        //matrix[length-1] = Integer.parseInt(substr);
        return matrix;
    }
    
    static int[][] inversion(int B[][])
    {
        int l = B.length;
        double [][]A = new double[l][l];
        for(int i=0; i<l; i++){
            for(int j=0; j<l; j++)
                A[i][j] = (double)B[i][j];
        }
        
        int n = A.length;
        int row[] = new int[n];
        int col[] = new int[n];
        double temp[] = new double[n];
        int hold, I_pivot, J_pivot;
        double pivot, abs_pivot;

        if (A[0].length != n) {
            System.out.println("Error in Matrix.invert, inconsistent array sizes.");
        }
        // установиим row и column как вектор изменений.
        for (int k = 0; k < n; k++) {
            row[k] = k;
            col[k] = k;
        }
        // начало главного цикла
        for (int k = 0; k < n; k++) {
            // найдем наибольший элемент для основы
            pivot = A[row[k]][col[k]];
            I_pivot = k;
            J_pivot = k;
            for (int i = k; i < n; i++) {
                for (int j = k; j < n; j++) {
                    abs_pivot = Math.abs(pivot);
                    if (Math.abs(A[row[i]][col[j]]) > abs_pivot) {
                        I_pivot = i;
                        J_pivot = j;
                        pivot = A[row[i]][col[j]];
                    }
                }
            }
            if (Math.abs(pivot) < 1.0E-10) {
                System.out.println("Matrix is singular !");
                return B;
            }
            //перестановка к-ой строки и к-ого столбца с стобцом и строкой, содержащий основной элемент(pivot основу)
            hold = row[k];
            row[k] = row[I_pivot];
            row[I_pivot] = hold;
            hold = col[k];
            col[k] = col[J_pivot];
            col[J_pivot] = hold;
            // k-ую строку с учетом перестановок делим на основной элемент
            A[row[k]][col[k]] = 1.0 / pivot;
            for (int j = 0; j < n; j++) {
                if (j != k) {
                    A[row[k]][col[j]] = A[row[k]][col[j]] * A[row[k]][col[k]];
                }
            }
            // внутренний цикл
            for (int i = 0; i < n; i++) {
                if (k != i) {
                    for (int j = 0; j < n; j++) {
                        if (k != j) {
                            A[row[i]][col[j]] = A[row[i]][col[j]] - A[row[i]][col[k]] *
                                    A[row[k]][col[j]];
                        }
                    }
                    A[row[i]][col[k]] = -A[row[i]][col[k]] * A[row[k]][col[k]];
                }
            }
        }
        
        for(int i=0; i<l; i++){
            for(int j=0; j<l; j++){
                if(A[i][j] >= 0)
                    A[i][j]+=1.0;
                else
                    A[i][j]-=1.0;
                B[i][j] = (int)A[i][j];
            }
        }
        
        return B;
    }
    
    static String frequencyAnalysis(String str, String lan){
        int first, n;
        String text = str;
        text = text.toLowerCase();
        text = removePunct(text);
        text = text.replaceAll("\n", "");
        text = text.replaceAll(" ", "");
        text = text.replaceAll("ё", "е");
        if(lan == "CYR"){
            first = (int)'а';
            n = 32;
        }
        else{
            first = (int)'a';
            n = 26;
        }
        
        int[]arr = new int[n];
        char[] textArr = text.toCharArray();
        int textlen = text.length();
        for(int i=0; i < textlen; i++){
           arr[ (int)textArr[i]-first ]++;
        }
        
        str = "";
        for(int i=0; i<n; i++){
            char let = (char) (i+first);
            double freq = (1.0*arr[i])/textlen;
            str+= Character.toString(let) + " - " + Integer.toString(arr[i]) + " - " + Double.toString(round(freq, 4)) + "\n";
        }
        return str;
    }
    
    public static String removePunct(String str) {
        StringBuilder result = new StringBuilder(str.length());
        for (int i = 0; i < str.length(); i++) {
            char c = str.charAt(i);
            if (Character.isAlphabetic(c) || Character.isDigit(c) || Character.isSpaceChar(c)) {
                result.append(c);
            }
        }
        return result.toString();
    }
    
    public static double round(double value, int places) {
        if (places < 0) throw new IllegalArgumentException();

        long factor = (long) Math.pow(10, places);
        value = value * factor;
        long tmp = Math.round(value);
        return (double) tmp / factor;
    }
}
