package com.davidfrisby.smalltests.test;
import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import com.davidfrisby.smalltests.ReverseSentence;

public class ReverseSentencePrimitiveTest {

	ReverseSentence test;

	@Before
	public void setUp() throws Exception {

		test = new ReverseSentence();
	}

	@After
	public void tearDown() throws Exception {

		test = null;
	}

	@Test
	public void testBigSen() {
		final char[] test_sen = { 'D', 'a', 'v', 'i', 'd', ' ', 'F', 'r', 'i', 's', 'b', 'y', ' ', 'T', 'e', 's', 't', ' ',
				'G', 'o', 'o', 'd' };
		final char[] test_expected = { 'G', 'o', 'o', 'd', ' ', 'T', 'e', 's', 't', ' ', 'F', 'r', 'i', 's', 'b', 'y', ' ',
				'D', 'a', 'v', 'i', 'd' };
		final char[] ressult = ReverseSentence.reverseSentencePrimitive(test_sen);
		System.out.print(ressult);
		assertArrayEquals(test_expected, ressult);
	}

	@Test
	public void testSmallSen() {
		final char[] test_sen = { 'D', 'a', 'v', 'i', 'd', ' ', 'T', 'e', 's', 't' };
		final char[] test_expected = { 'T', 'e', 's', 't', ' ', 'D', 'a', 'v', 'i', 'd' };
		final char[] ressult = ReverseSentence.reverseSentencePrimitive(test_sen);
		System.out.print(ressult);
		assertArrayEquals(test_expected, ressult);
	}

	@Test
	public void testOneLetterSen() {
		final char[] test_sen = { 'D', ' ', 'T' };
		final char[] test_expected = { 'T', ' ', 'D' };
		final char[] ressult = ReverseSentence.reverseSentencePrimitive(test_sen);
		System.out.print(ressult);
		assertArrayEquals(test_expected, ressult);
	}

	@Test
	public void testOneLetter() {
		final char[] test_sen = { 'D' };
		final char[] test_expected = { 'D' };
		final char[] ressult = ReverseSentence.reverseSentencePrimitive(test_sen);
		System.out.print(ressult);
		assertArrayEquals(test_expected, ressult);
	}

	@Test
	public void testNull() {
		final char[] test_sen = null;
		final char[] test_expected = null;
		final char[] ressult = ReverseSentence.reverseSentencePrimitive(test_sen);
		assertArrayEquals(test_expected, ressult);
	}
}
