<template>
  <el-dialog v-model="dialogFormVisible" title="Настройки" width="500">
    <el-form :model="form">
      <div style="display: flex; align-items: center; margin-bottom: 10px">
        <div style="margin-right: 10px">Получать уведомления</div>
        <el-checkbox></el-checkbox>
      </div>
      <el-form-item label="Сервисы" :label-width="formLabelWidth">
        <el-select multiple v-model="form.region" placeholder="Выберите">
          <el-option label="Gmail" value="shanghai"/>
          <el-option label="Telegram" value="beijing"/>
        </el-select>
      </el-form-item>
    </el-form>
    <template #footer>
      <div class="dialog-footer">
        <el-button @click="dialogFormVisible = false">Отмена</el-button>
        <el-button type="primary" @click="dialogFormVisible = false">
          Сохранить изменения
        </el-button>
      </div>
    </template>
  </el-dialog>
</template>

<script setup lang="ts">

</script>

<style scoped>

</style>