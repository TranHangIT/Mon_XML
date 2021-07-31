<?xml version="1.0" encoding="UTF-8"?>
 
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>         
    <xsl:template match="lophoc">
        <html>
            <head>
                <title>Vi du lop hoc</title>
                <style>
                    table{
                    border-collapse: collapse;                        
                    }
                    th,td{
                    padding: 5px;
                    }
                    tr:nth-child(odd){
                    background-color:#ccffcc;
                    }
                    tr:nth-child(even){
                    background-color:#ffccff;
                    }
                    
                </style>
            </head>
            <body>
                <h2>Hello from lophoc</h2>
                <table border="1">
                    <tr>
                        <th>Thu tu</th>
                        <th>Ho ten</th>
                        <th>Tuoi</th>
                        <th>Dia chi</th>
                    </tr>
                    <xsl:apply-templates select="sinhvien"/> <!-- khong dua code <xsl:template match="sinhvien">  thay the vao day -->
                </table>
                So luong sinh vien: <xsl:value-of select="count(sinhvien/tuoi)"/>
                <br/>                
                Tong so tuoi cua sinh vien: <xsl:value-of select="sum(sinhvien/tuoi)"/>
                <br/>                               
            </body>
        </html>
    </xsl:template>    
    <xsl:template match="sinhvien">     
        <tr>
            <td>
                <xsl:number value="position()" format="1."/>
            </td>
            <td>
                <xsl:value-of select="hoten"/>
            </td>
            <td>
                <xsl:value-of select="tuoi"/>
            </td>
            <td>
                <xsl:value-of select="diachi"/>
            </td>
        </tr>       
    </xsl:template>        
</xsl:stylesheet>
