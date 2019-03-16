<template>
  <UserForm
    :id="id"
    :create="false"
  />
</template>

<script>
// @ is an alias to /src
import UserForm from '@/components/UserForm.vue';

export default {
  name: 'UpdateUser',
  components: {
    UserForm,
  },
  props: {
    id: String,
  },
  mounted() {

  },
};
</script>
