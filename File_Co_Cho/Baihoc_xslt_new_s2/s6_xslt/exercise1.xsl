    <xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
        <xsl:output method="html"/>

        <!-- TODO customize transformation rules
                 syntax recommendation http://www.w3.org/TR/xslt
            -->
        <xsl:template match="/">
            <html>
                <head>
                    <title>showrooms.xsl</title>
                </head>
                <body>
                    <xsl:for-each select="//showroom">
                        <h2 style="color:blue">Showroom: <xsl:value-of select="address"/></h2>
                        <h3>Pay: $<xsl:value-of select="pay"/></h3>
                        <xsl:for-each select="//batch">
                            <h4 style="color:green">Year: <xsl:value-of select="year"/></h4>
                            <h5 style="color:green">Allowance: $<xsl:value-of select="allowance"/></h5>
                            <table border="1">
                                <tr bgcolor="pink">
                                    <th width="200">Name</th>
                                    <th width="70">Age</th>
                                </tr>
                                <xsl:for-each select="employee">
                                    <tr bgcolor="cyan">
                                        <td><xsl:value-of select="name"/></td>
                                        <td align="center"><xsl:value-of select="age"/></td>
                                    </tr>
                                </xsl:for-each>
                            </table>
                        </xsl:for-each>
                    </xsl:for-each>
                </body>
            </html>
        </xsl:template>

    </xsl:stylesheet>