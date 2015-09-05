package com.davidfrisby.smalltests.test;
import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import com.davidfrisby.smalltests.ReverseSentence;

public class ReverseSentenceTest {

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
		final String test_sen = "David Frisby Test";
		final String test_expected = "Test Frisby David";
		final String ressult = ReverseSentence.reverseSentence(test_sen);
		System.out.print(ressult);
		assertEquals(test_expected, ressult);
	}

	@Test
	public void testSmallSen() {
		final String test_sen = "David Test";
		final String test_expected = "Test David";
		String ressult = ReverseSentence.reverseSentence(test_sen);
		System.out.print(ressult);
		assertEquals(test_expected, ressult);
	}

	@Test
	public void testOneLetterSen() {
		final String test_sen = "D T";
		final String test_expected = "T D";
		final String ressult = ReverseSentence.reverseSentence(test_sen);
		System.out.print(ressult);
		assertEquals(test_expected, ressult);
	}

	@Test
	public void testOneLetter() {
		final String test_sen = "D";
		final String test_expected = "D";
		final String ressult = ReverseSentence.reverseSentence(test_sen);
		System.out.print(ressult);
		assertEquals(test_expected, ressult);
	}

	@Test
	public void testNull() {
		final String test_sen = null;
		final String test_expected = null;
		final String ressult = ReverseSentence.reverseSentence(test_sen);
		assertEquals(test_expected, ressult);
	}
}
