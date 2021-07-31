<?xml version="1.0" encoding="ISO-8859-1"?>

<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="class">
        <!--<xsl:template match="/">-->
        <html>
            <head>
                <title>Vi du attribute</title>
            </head>
            <body>            
                <xsl:apply-templates select="student"/>
                <!--            <xsl:apply-templates select="class/student"/>-->
            </body>
        </html>
    </xsl:template>
    <xsl:template match="student">
        <!--<xsl:template match="class/student">-->
        <p>    
            <xsl:value-of select="@id"/> 
            <xsl:text>*</xsl:text>
            <xsl:value-of select="."/>  <!-- Lay ra ten cua sinh vien -->      
        </p>
    </xsl:template>
</xsl:stylesheet>

