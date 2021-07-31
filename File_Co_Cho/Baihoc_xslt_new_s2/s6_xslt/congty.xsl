<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>

    <!-- TODO customize transformation rules 
         syntax recommendation http://www.w3.org/TR/xslt 
    -->
    <xsl:template match="/">
        <html>
            <head>
                <title>Cong ty</title>
                <h1>Nhan vien trong cong ty</h1>
                <style>
                    table{
                    border-collapse: collapse;
                    }
                    
                    td {
                    padding: 3px;
                    }
                </style>
            </head>
            <body>
                <table border="1" width="70%" >
                    <tr>
                        <th>Thu tu</th>
                        <th>Ma nhan vien</th>
                        <th>Ho ten</th>
                        <th>Tuoi</th>
                        <th>Dia chi</th>
                    </tr>
                    <xsl:for-each select="congty/nhanvien">
                        <xsl:sort select="tuoi" data-type="number"/>
                        <xsl:if test="tuoi > 30">
                            <tr>
                                <td>
                                    <xsl:number value="position()" format="1." />
                                </td>
                                <td>
                                    <xsl:value-of select="manv" />
                                </td>
                                <td>
                                    <xsl:value-of select="hoten" />                     
                                </td>
                                <td>
                                    <xsl:value-of select="tuoi" /> 
                                </td>
                                <td>
                                    <xsl:value-of select="diachi" />
                                </td>
                            </tr>
                        </xsl:if>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
