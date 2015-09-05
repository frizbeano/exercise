package com.davidfrisby.smalltests;

public final class ReverseSentence {
	
	
	/**
	 * Reverse an array of chars.
	 * Example: STRING becomes GNIRTS
	 * 
	 * @param inputArray - The char array 
	 * @return	the reverse of the input inputArray
	 */
	public static char[] reverseSentencePrimitive(final char[] inputArray) {

		if (inputArray == null || inputArray.length < 1) {
			return inputArray;
		}

		final char emptySpaceChar = ' ';
		final char[] resultArray = new char[inputArray.length];
		int indexMakerFront;
		int indexMarkerBack = inputArray.length;
		int indexCurrentPosition = 0;

		for (int i = indexMarkerBack - 1; i >= -1; --i) {
			if (i == -1 || inputArray[i] == emptySpaceChar) {
				indexMakerFront = i + 1;

				for (int j = indexMakerFront; j < indexMarkerBack; ++j) {
					resultArray[indexCurrentPosition] = inputArray[j];
					indexCurrentPosition++;
				}

				if (indexCurrentPosition < resultArray.length) {
					resultArray[indexCurrentPosition] = emptySpaceChar;
					indexCurrentPosition++;
				}
				indexMarkerBack = indexMakerFront - 1;
			}
		}
		return resultArray;
	}
	
	
	/**
	 * Reverse an array of chars.
	 * Example: STRING becomes GNIRTS
	 * 
	 * @param inputString - The char array 
	 * @return	the reverse of the input inputString
	 */
	public static String reverseSentence(final String inputString) {

		if (inputString == null || inputString.length() < 1) {
			return inputString;
		}
		
		final String emptySpaceString = " ";
		final StringBuilder result = new StringBuilder();
		final String[] splitValues = inputString.split(" ");
		
		result.append(splitValues[splitValues.length-1]);
		for(int i = splitValues.length-1 ; i > 0; i-- ){
			result.append(emptySpaceString).append(splitValues[i-1]);		
		}
		return result.toString();
	}	
	
	
}
