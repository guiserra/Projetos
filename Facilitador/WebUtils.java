package br.com.siteseeing.santander.utils;

import java.util.ArrayList;

import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class WebUtils {

	public static void abreUmaNovaAba(WebDriver driver) {
		((JavascriptExecutor) driver).executeScript("window.open()");
	}

	public static void fechaAbaAtual(WebDriver driver) {
		driver.close();
	}

	public static void navegaParaAba(WebDriver driver, int aba) {
		ArrayList<String> tabs = new ArrayList<String>(driver.getWindowHandles());
		driver.switchTo().window(tabs.get(aba));
	}

	public static void esperarElementoClicavelXpath(WebDriver driver, int tempo, String xpath) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.elementToBeClickable(By.xpath(xpath)));
	}

	public static void esperarElementoClicavelId(WebDriver driver, int tempo, String id) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.elementToBeClickable(By.id(id)));
	}

	public static void esperarElementoClicavelClassName(WebDriver driver, int tempo, String className) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.elementToBeClickable(By.className(className)));
	}

	public static void esperarElementoClicavelTagName(WebDriver driver, int tempo, String tagName) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.elementToBeClickable(By.tagName(tagName)));
	}

	public static void esperarElementoClicavelPartialLinkText(WebDriver driver, int tempo, String partialLinkText) {
		new WebDriverWait(driver, tempo)
				.until(ExpectedConditions.elementToBeClickable(By.partialLinkText(partialLinkText)));
	}

	public static void esperarElementoClicavelName(WebDriver driver, int tempo, String name) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.elementToBeClickable(By.name(name)));
	}

	public static void esperarElementoClicavelLinkText(WebDriver driver, int tempo, String linkText) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.elementToBeClickable(By.linkText(linkText)));
	}

	public static void esperarElementoClicavelCssSelector(WebDriver driver, int tempo, String cssSelector) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.elementToBeClickable(By.cssSelector(cssSelector)));
	}

	public static void clicarNoElementoXpath(WebDriver driver, String xpath) {
		driver.findElement(By.xpath(xpath)).click();
	}

	public static void clicarNoElementoId(WebDriver driver, String id) {
		driver.findElement(By.xpath(id)).click();
	}

	public static void clicarNoElementoClassName(WebDriver driver, String className) {
		driver.findElement(By.className(className)).click();
	}

	public static void clicarNoElementoTagName(WebDriver driver, String tagName) {
		driver.findElement(By.tagName(tagName)).click();
	}

	public static void clicarNoElementoPartialLinkText(WebDriver driver, String partialLinkText) {
		driver.findElement(By.partialLinkText(partialLinkText)).click();
	}

	public static void clicarNoElementoName(WebDriver driver, String name) {
		driver.findElement(By.name(name)).click();
	}

	public static void clicarNoElementoLinkText(WebDriver driver, String linkText) {
		driver.findElement(By.linkText(linkText)).click();
	}

	public static void clicarNoElementoCssSelector(WebDriver driver, String cssSelector) {
		driver.findElement(By.cssSelector(cssSelector)).click();
	}

	public static void executarScriptJS(WebDriver driver, String script, WebElement elemento) {
		((JavascriptExecutor) driver).executeScript(script, elemento);
	}

	public static void esperarElementoVisivelLinkText(WebDriver driver, int tempo, String linkText) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.visibilityOfElementLocated(By.linkText(linkText)));
	}

	public static void esperarElementoVisivelXpath(WebDriver driver, int tempo, String xpath) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.visibilityOfElementLocated(By.xpath(xpath)));
	}

	public static void esperarElementoVisivelId(WebDriver driver, int tempo, String id) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.visibilityOfElementLocated(By.id(id)));
	}

	public static void esperarElementoVisivelClassName(WebDriver driver, int tempo, String className) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.visibilityOfElementLocated(By.className(className)));
	}

	public static void esperarElementoVisivelTagName(WebDriver driver, int tempo, String tagName) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.visibilityOfElementLocated(By.tagName(tagName)));
	}

	public static void esperarElementoVisivelPartialLinkText(WebDriver driver, int tempo, String partialLinkText) {
		new WebDriverWait(driver, tempo)
				.until(ExpectedConditions.visibilityOfElementLocated(By.partialLinkText(partialLinkText)));
	}

	public static void esperarElementoVisivelName(WebDriver driver, int tempo, String name) {
		new WebDriverWait(driver, tempo).until(ExpectedConditions.visibilityOfElementLocated(By.name(name)));
	}

	public static void esperarElementoVisivelCssSelector(WebDriver driver, int tempo, String cssSelector) {
		new WebDriverWait(driver, tempo)
				.until(ExpectedConditions.visibilityOfElementLocated(By.cssSelector(cssSelector)));
	}

	public static void digitarPausadamenteId(WebDriver driver, int qnt, String id, String chave)
			throws InterruptedException {
		WebElement x = driver.findElement(By.id(id));
		for (int y = 0; y < qnt; y++) {
			char n = chave.charAt(y);
			String v = new Character((char) n).toString();
			x.sendKeys(v);
			Thread.sleep(90);
		}
	}

	public static void digitarPausadamenteXpath(WebDriver driver, int qnt, String xpath, String chave)
			throws InterruptedException {
		WebElement x = driver.findElement(By.xpath(xpath));
		for (int y = 0; y < qnt; y++) {
			char n = chave.charAt(y);
			String v = new Character((char) n).toString();
			x.sendKeys(v);
			Thread.sleep(90);
		}
	}
	
	
}
