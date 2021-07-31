
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>
       
        <!-- TODO customize transformation rules
                 syntax recommendation http://www.w3.org/TR/xslt
            -->
    <xsl:template match="/">
        <html>
            <head>
                <title>Assignment 7</title>
            </head>
            <body>
                <xsl:for-each select="//department">
                    <h2 style="color:green">Department:
                        <xsl:value-of select="departmentName"/>
                    </h2>
                    <table border="1">
                        <tr bgcolor="greenyellow">
                            <th width="200">Name</th>
                            <th width="70">Age</th>
                            <th width="100">Receive Date</th>
                            <th width="100">Level</th>
                            <th width="100">Income</th>
                        </tr>
                        <xsl:for-each select="employee">
                            <tr bgcolor="#ffccff">
                                <td>
                                    <xsl:value-of select="name"/>
                                </td>
                                <td align="center">
                                    <xsl:value-of select="age"/>
                                </td>
                                <td align="center">
                                    <xsl:value-of select="receiveDate"/>
                                </td>
                                <td align="center">
                                    <xsl:value-of select="level"/>
                                </td>
                                <td align="center">
                                    <xsl:value-of select="income"/>
                                </td>
                            </tr>
                        </xsl:for-each>
                    </table>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
       
</xsl:stylesheet>
