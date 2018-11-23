package edu.uniandes.automatizacion.servicios.tests;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.test.jdbc.JdbcTestUtils;
import org.springframework.transaction.annotation.Transactional;

import javax.sql.DataSource;

import static org.springframework.test.util.AssertionErrors.assertEquals;

@RunWith(SpringJUnit4ClassRunner.class)
@Transactional
public class DBTest {

    private JdbcTemplate jdbcTemplate;

    @Autowired
    public void setDataSource(DataSource dataSource) {
        jdbcTemplate = new JdbcTemplate(dataSource);
    }

    @Before
    public void setUp() {
    }

    @After
    public void tearDown() {
    }

    @Test
    public void testInsert() {
        assertEquals("El experimento no se guardó correctamente", JdbcTestUtils.countRowsInTable(jdbcTemplate, "experiment"), 1);
        assertEquals("Las fases no se guardaron correctamente", JdbcTestUtils.countRowsInTable(jdbcTemplate, "phase"), 2);
        assertEquals("Las pruebas no se guardaron correctamente", JdbcTestUtils.countRowsInTable(jdbcTemplate, "test"), 24);
        assertEquals("Los elementos no se guardaron correctamente", JdbcTestUtils.countRowsInTable(jdbcTemplate, "element"), 96);
        assertEquals("Los grupos no se guardaron correctamente", JdbcTestUtils.countRowsInTable(jdbcTemplate, "grupo"), 1);
    }


    @Test
    public void testData() {
        assertEquals("El experimento no se guardó correctamente", JdbcTestUtils.countRowsInTableWhere(jdbcTemplate, "experiment", "name= 'Experimento1'"), 1);
        assertEquals("Las fases no se guardaron correctamente", JdbcTestUtils.countRowsInTableWhere(jdbcTemplate, "phase", "name = 'Fase1'"), 1);
        assertEquals("Las pruebas no se guardaron correctamente", JdbcTestUtils.countRowsInTableWhere(jdbcTemplate, "test", "name = 'PE106'"), 1);
        assertEquals("Los elementos no se guardaron correctamente", JdbcTestUtils.countRowsInTableWhere(jdbcTemplate, "element", "name = 'P1'"), 10);
        assertEquals("Los grupos no se guardaron correctamente", JdbcTestUtils.countRowsInTableWhere(jdbcTemplate, "grupo", "name = 'rRupo1'"), 1);
    }

}