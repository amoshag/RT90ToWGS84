# RT90ToWGS84
Simple command line tool to convert RT90 coordinates (Sweden) to WGS84, using the code in http://blog.sallarp.com/translate-coordinates-between-rt90-wgs84-and-sweref99-using-net/

The program reads a file named input.csv from the running directory, the file should be in csv format (comma separated) with two columns, the first one is the X coordinate of RT90 and the second is the Y coordinate.
The program output a file named output.csv with two columns, the first one is the Longitudue and the second is the Latitude (WGS84).
