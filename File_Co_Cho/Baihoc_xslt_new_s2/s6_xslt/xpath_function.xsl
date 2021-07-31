<?xml version="1.0" encoding="UTF-8"?>

<!--
    Document   : xpath_function.xsl
    Created on : September 30, 2011, 4:36 PM
    Author     : Dang Quynh Nga
    Description:
        Purpose of transformation follows.
-->

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>

    <!-- TODO customize transformation rules 
         syntax recommendation http://www.w3.org/TR/xslt 
    -->
    <xsl:template match="/">
        <html>
            <head>
                <title>Function</title>
            </head>
            <body>
              
                <xsl:for-each select="bookstore/book"> <!-- or //book -->
                    <ul>
                        <li>
                            <xsl:value-of select="title" />
                            <font color="blue">
                                <b>
                                    <xsl:text> - Length of title: </xsl:text>
                                    <xsl:value-of select="string-length(title)"/>
                                </b>
                            </font>
                        </li>
                        <li>
                            <i>
                                <font color="red">
                                    <xsl:value-of select="name()" />
                                    <xsl:text>: </xsl:text>
                                </font>
                            </i>
                            <xsl:value-of select="author" />
                        </li>
                        <li>
                            <xsl:value-of select="year" />
                        </li>
                        <li>
                            <xsl:value-of select="price" />
                        </li>
                        <li>
                            <b>
                                <xsl:text>Price * 2 = </xsl:text>
                                <xsl:value-of select="price*2" />
                            </b>
                        </li>
                    </ul>
                </xsl:for-each>
                
<!-- total and count function -->
                <xsl:text>Total cost of books =</xsl:text>
                <xsl:value-of select="sum(//bookstore/book/price)"/>
                <p> </p>
                <p>Total number of books =
                    <xsl:value-of select="count(//bookstore/book)"/>
                </p>
            </body>
        </html>
 
    </xsl:template>
</xsl:stylesheet>

